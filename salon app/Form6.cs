using System;
using System.Linq;
using System.Windows.Forms;

namespace salon_app
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            // If not wired in Designer, you can wire events here:
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            button1.Click += button1_Click;
            button2.Click += button2_Click;

            // Start with Cash selected (optional)
            radioButton1.Checked = true;
            SetCardFieldsEnabled(false);
        }

        // Cash on appointment
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                SetCardFieldsEnabled(false);   // grey out card fields
        }

        // Credit / Debit Card
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                SetCardFieldsEnabled(true);    // enable card fields
        }

        // gray out card details if cash selected 
        private void SetCardFieldsEnabled(bool enabled)
        {
            textBox1.Enabled = enabled;   // First Name
            textBox2.Enabled = enabled;   // Last Name
            textBox3.Enabled = enabled;   // Card No
            textBox4.Enabled = enabled;   // CVV
            comboBox1.Enabled = enabled;  // Month
            comboBox2.Enabled = enabled;  // Year

            if (!enabled)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
            }
        }

        // Cancel button
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   // add juans booking page
        }

        // Proceed button
        private void button2_Click(object sender, EventArgs e)
        {
            // If Cash on appointment
            if (radioButton1.Checked)
            {
                MessageBox.Show("Booking is successful, You can pay when you arrive!",
                                "Cash on appointment",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            // If Card selected
            if (radioButton2.Checked)
            {
                string firstName = textBox1.Text.Trim();
                string lastName = textBox2.Text.Trim();
                string cardNo = textBox3.Text.Trim();
                string cvv = textBox4.Text.Trim();

                // Check required fields
                if (firstName == "" || lastName == "" || cardNo == "" || cvv == "" ||
                    comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
                {
                    MessageBox.Show("Please fill all card details.",
                                    "Missing information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return;
                }

                // Card number: 16 digits
                if (cardNo.Length != 16 || !cardNo.All(char.IsDigit))
                {
                    MessageBox.Show("Card number must be 16 digits.",
                                    "Invalid card number",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // CVV: 3 digits
                if (cvv.Length != 3 || !cvv.All(char.IsDigit))
                {
                    MessageBox.Show("CVV must be 3 digits.",
                                    "Invalid CVV",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                // if all fields are correct
                MessageBox.Show("Payment successful!",
                                "Thank You",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
