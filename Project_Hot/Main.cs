using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Hot
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Employees employee;
        Username user;
        public Form RefToLoginForm { get; set; } // refers to Login Form
        

        private void button1_Click(object sender, EventArgs e) // employee button
        {
            employee = new Employees();
            employee.RefToMainForm = this;
            employee.Show();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e) // user button
        {
            user = new Username();
            user.RefToMainForm = this;
            user.Show();
            this.Visible = false;
        }
        
        private void Main_FormClosing(object sender, FormClosingEventArgs e) //when closing, return to loginForm
        {
            this.RefToLoginForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
