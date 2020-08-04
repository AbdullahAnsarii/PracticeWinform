using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            loginMethod();
        }

        

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetMethod();
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                loginMethod();
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                resetMethod();
            }

 

        }

        private void loginMethod()
        {
            //this.Hide();
            string userID = textUsername.Text;
            string pass = textPassword.Text;

            if (userID == "abdullah" && pass == "abc123")
            {
                this.Hide();
                Form2 secondPage = new Form2();
                secondPage.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password!!!");
            }
        }

        private void resetMethod()
        {
            textUsername.Text = "";
            textPassword.Text = "";
        }
    }
}
