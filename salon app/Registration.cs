using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace salon_app
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            if (textBoxFullName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields");
                textBoxFullName.Focus();
                return;
            }

            if (textBoxEmail.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields");
                textBoxEmail.Focus();
                return;
            }

            // check if there is a @
            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address");
                textBoxEmail.Focus();
                return;
            }

            if (textBoxUserName.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields");
                textBoxUserName.Focus();
                return;
            }

            if (textBoxPhone.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields");
                textBoxPhone.Focus();
                return;
            }

            // check that are only numbers
            if (!long.TryParse(textBoxPhone.Text, out _))
            {
                MessageBox.Show("Phone number only can contain numbers");
                textBoxPhone.Focus();
                return;
            }

            // check that phone field have exactly 10 numbers
            if (textBoxPhone.Text.Length != 10)
            {
                MessageBox.Show("Phone number must have exactly 10 digits");
                textBoxPhone.Focus();
                return;
            }

            if (textBoxPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields");
                textBoxPassword.Focus();
                return;
            }

            if (textBoxConfirmPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill all fields");
                textBoxConfirmPassword.Focus();
                return;
            }

            // check if password and confirm password are same
            if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match");
                textBoxConfirmPassword.Focus();
                return;
            }

           // MessageBox.Show("Successful registration");

            this.Hide();
            Login login = new Login();

            login.FormClosed += (s, args) => this.Close();
            login.Show();

            // path 
            string filePath = @"C:\Users\Public\registration_data.txt"; 

            
            string userData =
                "Full Name: " + textBoxFullName.Text + Environment.NewLine +
                "Email: " + textBoxEmail.Text + Environment.NewLine +
                "User Name: " + textBoxUserName.Text + Environment.NewLine +
                "Phone: " + textBoxPhone.Text + Environment.NewLine +
                "Password: " + textBoxPassword.Text + Environment.NewLine +
                "----------------------------------------" + Environment.NewLine;

            
            System.IO.File.AppendAllText(filePath, userData);

            MessageBox.Show("Successful registration. Data saved");

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();

            login.FormClosed += (s, args) => this.Close();
            login.Show();
        }
    }
}
