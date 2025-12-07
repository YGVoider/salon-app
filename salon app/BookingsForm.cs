using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using System.IO;

namespace salon_app
{
    public partial class BookingsForm : Form
    {
        public BookingsForm()
        {

           

            InitializeComponent();
            



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookingsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // path 
            string folder = @"C:\Users\juan pablo\source\repos\salon-app";
            string filePath = Path.Combine(folder, "booking_data.txt");



            string service = comboBox1.SelectedItem?.ToString() ?? "Not selected";
            string date = dateTimePicker1.Value.ToShortDateString();
            string time = comboBox2.SelectedItem?.ToString() ?? "Not selected";
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();

            // Validation field phone
            if (name == "" || phone == "" || service == "Not selected" || time == "Not selected")
            {
                MessageBox.Show("Please complete all fields before confirming.");
                return;
            }

            if (!long.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Phone number only can contain numbers");
                textBox2.Focus();
                return;
            }

            // check that phone field have exactly 10 numbers
            if (textBox2.Text.Length != 10)
            {
                MessageBox.Show("Phone number must have exactly 10 digits");
                textBox2.Focus();
                return;
            }


            string bookingData =
                "Service: " + service + Environment.NewLine +
                "Date: " + date + Environment.NewLine +
                "Time: " + time + Environment.NewLine +
                "Name: " + name + Environment.NewLine +
                "Phone: " + phone + Environment.NewLine +
                "----------------------------------------" + Environment.NewLine;

            
            System.IO.File.AppendAllText(filePath, bookingData);

            MessageBox.Show("Booking saved successfully!");


        }
            private void buttonConfirm_Click(object sender, EventArgs e)
        {
            

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

