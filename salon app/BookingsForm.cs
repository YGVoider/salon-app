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

namespace salon_app
{
    public partial class BookingsForm : Form
    {
        public BookingsForm()
        {
            InitializeComponent();

            
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dddd, dd MMMM yyyy";
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
            string filePath = @"C:\Users\Public\booking_data.txt";

           
            string service = comboBox1.SelectedItem?.ToString() ?? "Not selected";
            string date = dateTimePicker1.Value.ToShortDateString();
            string time = comboBox2.SelectedItem?.ToString() ?? "Not selected";
            string name = textBox1.Text.Trim();
            string phone = textBox2.Text.Trim();

            // Validation
            if (name == "" || phone == "" || service == "Not selected" || time == "Not selected")
            {
                MessageBox.Show("Please complete all fields before confirming.");
                return;
            }

            
            string bookingData =
                "Service: " + service + Environment.NewLine +
                "Date: " + date + Environment.NewLine +
                "Time: " + time + Environment.NewLine +
                "Name: " + name + Environment.NewLine +
                "Phone: " + phone + Environment.NewLine +
                "----------------------------------------" + Environment.NewLine;

            // Guardar en archivo
            System.IO.File.AppendAllText(filePath, bookingData);

            MessageBox.Show("Booking saved successfully!");


        }
            private void buttonConfirm_Click(object sender, EventArgs e)
        {
            

            
        }

    }
}

