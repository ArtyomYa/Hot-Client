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
    public partial class Username : Form
    {
        public Username()
        {
            InitializeComponent();
        }

        public Form RefToMainForm { get; set; } // refers to Main Form

        bool status_check = false; // new added 30.03.21

        private bool detailsFillCheck(string txt1, string txt2, string txt3) //checks if all the textboxs are not empty   30.03.21
        {
            if (txt1 == "" || txt2 == "" || txt3 == "")
                return false;
            else
                return true;
        }

        string[] UserList;
        private void showAllUsername()
        {
            
            UserList = null;
            listView1.Items.Clear();
            string str;
            str = SendToServer.RequestToServer("02");
            UserList = str.Split('$');

            foreach (string user in UserList)
            {
                listView1.Items.Add(new ListViewItem(user.Split('~')));
            }

            /*listBox1.Items.Clear();
            string str;
            str = SendToServer.RequestToServer("02");
            string[] UserList = str.Split('$');
            foreach (string user in UserList)
            {
                listBox1.Items.Add(user);
            }*/
        }
        private string Status()
        {
            string str;
            if (Active.Checked == true)
            {
                str = "Active";
                status_check = true;
            }
            else if (Inactive.Checked == true)
            {
                str = "Inactive";
                status_check = true;
            }
            else
                str = "";
            return str;
        }

        private void button2_Click(object sender, EventArgs e) //update selected user button
        {
            string str;
            string str_status = Status();
            if (detailsFillCheck(textBox1.Text, textBox2.Text, textBox3.Text) == true && status_check == true)
            {
                DialogResult dialogResult = MessageBox.Show("Update user " + textBox2.Text + "?", "Update User", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    str = SendToServer.RequestToServer("00" + textBox1.Text + "$" + textBox2.Text.Trim() + "$" + textBox3.Text.Trim() + "$" + str_status);
                    MessageBox.Show(str);
                    showAllUsername();
                    textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Action canceled");
                }
            }
            else
                MessageBox.Show("One or more details not filled");
        }

        private void button1_Click(object sender, EventArgs e) // create (add) new user button
        {
            string str;
            string str_status = Status();
            if (detailsFillCheck(textBox1.Text, textBox2.Text, textBox3.Text) == true && status_check == true)
            {
                DialogResult dialogResult = MessageBox.Show("Create new user " + textBox2.Text + "?", "Create new User", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    str = SendToServer.RequestToServer("01" + textBox1.Text + "$" + textBox2.Text + "$" + textBox3.Text + "$" + str_status);
                    showAllUsername();
                    MessageBox.Show(str);
                    textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Action canceled");
                }
            }
            else
                MessageBox.Show("One or more details not filled");
        }

        private void button3_Click(object sender, EventArgs e) //show all users button
        {
            showAllUsername();
        }

        private void button4_Click(object sender, EventArgs e) // delete selected user button
        {
            DialogResult dialogResult = MessageBox.Show("Delete user " + textBox2.Text + "?", "Delete User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string str;
                str = SendToServer.RequestToServer("03" + textBox2.Text);
                MessageBox.Show(str);
                showAllUsername();
                textBox1.Text = textBox2.Text = textBox3.Text = string.Empty;
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Action canceled");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //????????????????
        {

        }

        private void Username_FormClosed(object sender, FormClosedEventArgs e) // when closed return to main form
        {
            this.RefToMainForm.Show();
        }

        private void Username_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
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
        }
    }
}
