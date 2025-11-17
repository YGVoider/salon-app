using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salon_app
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hardcoded login
            string correctEmail = "admin@yogi.com";
            string correctPassword = "12345";

            // user inputs
            string email = textBox1.Text;
            string password = textBox2.Text;

            // Check if the fields are empty
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                label3.Text = "Please enter credentials!";
                return;
            }

            // Validate credentials
            if (email == correctEmail && password == correctPassword)
            {
                label3.Text = "login successful! welcome to salon YOGI";

                this.Hide(); // hide the login form
                Dashboard dash = new Dashboard();

                dash.FormClosed += (s, args) => this.Close(); // close the login form if the dashboard form closed
                dash.Show();
            }
            else
            {
                label3.Text = "wrong password or email!";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // hide the login form
            Registration reg = new Registration();

            reg.FormClosed += (s, args) => this.Close(); // close the login form if the registration form closed
            reg.Show();
        }
    }
}
