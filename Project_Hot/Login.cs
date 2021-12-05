using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project_Hot
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Main mainForm;
        
        private void button1_Click(object sender, EventArgs e) // login button
        {
            string employee_type = SendToServer.RequestToServer("08" + textBox1.Text + "$" + textBox2.Text);
            if (employee_type == "Admin")
            {
                loginWelcomeMessage(textBox1.Text);
                clearLoginTextbox();
                LoginID.setLoginNum(0);
                mainForm = new Main();
                mainForm.RefToLoginForm = this; //reference in main form to this form
                mainForm.Show();
                this.Visible = false;
            }
            else if(employee_type == "Sales")
            {
                loginWelcomeMessage(textBox1.Text);
                clearLoginTextbox();
                LoginID.setLoginNum(1);
                mainForm = new Main();
                mainForm.RefToLoginForm = this; //reference in main form to this form
                mainForm.Show();
                this.Visible = false;
            }
            else if (employee_type == "Service")
            {
                loginWelcomeMessage(textBox1.Text);
                clearLoginTextbox();
                LoginID.setLoginNum(2);
                mainForm = new Main();
                mainForm.RefToLoginForm = this; //reference in main form to this form
                mainForm.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show(employee_type);
            }

        }
        
        private void clearLoginTextbox()
        {
            textBox1.Text = textBox2.Text = "";
        }

        private void loginWelcomeMessage(string username)
        {
            MessageBox.Show("Welcome " + textBox1.Text);
        }
    }
}
