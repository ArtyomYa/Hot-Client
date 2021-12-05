using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_Hot
{
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        public Form RefToMainForm { get; set; } // refers to Main Form

        string[] UserList;
        private void ShowAllEmployees() // func to show all the Employees. 
        {
            UserList = null;
            listView1.Items.Clear();
            string str;
            str = SendToServer.RequestToServer("06");
            UserList = str.Split('$');
            
            foreach (string user in UserList)
            {
                listView1.Items.Add(new ListViewItem(user.Split('~')));
            }
        }
        private int sumDigit(int num) // func for id number(sum of two digits)
        {
            int sum = 0;
            while(num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
        private Boolean idCheck(string id) // func check if id number is corect 
        {
            int sum = 0, i, num = 0;
            if (id.Length != 9)
            {
                MessageBox.Show("Id must have 9 digits");
                return false;
            }
            for (i = 0; i < id.Length - 1; i++)
            {
                if (!(id[i] >= '0' && id[i] <= '9'))
                {
                    MessageBox.Show("Id must have only digits");
                    return false;
                }      
            }
            for (i = 0; i < id.Length - 1; i++)
            {
                if (i % 2 == 0)
                    sum += int.Parse(id[i].ToString());
                else
                {
                    num = int.Parse(id[i].ToString()) * 2;
                    sum += sumDigit(num);
                }
            }
            sum += int.Parse(id[id.Length - 1].ToString());
            if (sum % 10 != 0)
            {
                MessageBox.Show("Id number is not correct");
                return false;
            }
            return true;
        }

        private bool detailsFillCheck(string txt1, string txt2, string txt3, string txt4, string txt5) //checks if all the textboxs are not empty   30.03.21
        {
            if (txt1 == "" || txt2 == "" || txt3 == "" || txt4 == "" || txt5 == "")
                return false;
            else
                return true;
        }

        bool type_check = false;
        private string Type() //check employee type
        {
            string str;
            if (Admin.Checked == true)
            {
                str = "Admin";
                type_check = true;
            }
            else if (Sales.Checked == true)
            {
                str = "Sales";
                type_check = true;
            }
            else if (Service.Checked == true)
            {
                str = "Service";
                type_check = true;
            }
            else
                str = "";
            return str;
        }
        private void button1_Click(object sender, EventArgs e) //create (add) new employee button
        {
            if (idCheck(textBox1.Text) == true) // check id id is corect
            {
                string str_type = Type();
                string str;
                if (detailsFillCheck(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text) == true && type_check == true)
                {
                    DialogResult dialogResult = MessageBox.Show("Create new employee " + textBox2.Text + "?", "Create new Employee", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        str = SendToServer.RequestToServer("05" + textBox1.Text + "$" + textBox2.Text.Trim() + "$" + textBox3.Text.Trim() + "$" + textBox4.Text.Trim() + "$" + textBox5.Text.Trim() + "$" + str_type);
                        ShowAllEmployees();
                        MessageBox.Show(str);
                        textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                        clearChkBoxs();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Action canceled");
                    }
                    
                }
                else
                    MessageBox.Show("One or more details not filled");
            }
            else // message if id is not corect
            {
                MessageBox.Show("Enter correct Id number");
            }
        }

        private void button2_Click(object sender, EventArgs e) //update employee button
        {
            string str_type = Type();
            string str;
            if (detailsFillCheck(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text) == true && type_check == true)
            {
                DialogResult dialogResult = MessageBox.Show("Update employee " + textBox2.Text + "?", "Update Employee", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    str = SendToServer.RequestToServer("04" + textBox1.Text + "$" + textBox2.Text.Trim() + "$" + textBox3.Text.Trim() + "$" + textBox4.Text.Trim() + "$" + textBox5.Text.Trim() + "$" + str_type);
                    MessageBox.Show(str);
                    textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
                    clearChkBoxs();
                    ShowAllEmployees();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Action canceled");
                }
                
            }
            else
                MessageBox.Show("One or more details not filled");

        }
        

        private void button3_Click(object sender, EventArgs e) //show all employee button
        {
            ShowAllEmployees();
        }

        private void button4_Click(object sender, EventArgs e) //delete selected employee and the user of the employee button
        {
            string str;
            DialogResult dialogResult = MessageBox.Show("Delete employee " + textBox2.Text + "?", "Delelte Employee", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                str = SendToServer.RequestToServer("07" + textBox1.Text);
                MessageBox.Show(str);
                ShowAllEmployees();
                textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = string.Empty;
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Action canceled");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            
        }

        private void Employees_FormClosed(object sender, FormClosedEventArgs e) // when closed return to main form
        {
            this.RefToMainForm.Show();
        }

        private void Employees_Load(object sender, EventArgs e)
        {

        }
        
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = null;
            string[] arrStr;
            if (listView1.FocusedItem == null) return;
            int i = listView1.FocusedItem.Index;
            str = UserList[i];
            arrStr = str.Split('~');
            textBox1.Text = arrStr[0].Trim();
            textBox2.Text = arrStr[1].Trim();
            textBox3.Text = arrStr[2].Trim();
            textBox4.Text = arrStr[3].Trim();
            textBox5.Text = arrStr[4].Trim();
        }

        private void clearChkBoxs()
        {
            Admin.Checked = false;
            Sales.Checked = false;
            Service.Checked = false;
        }
    }
     
}
