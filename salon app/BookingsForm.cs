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
            comboBox2.Items.Clear(); 

            if (comboBox1.SelectedItem == null) return;

            string selectedService = comboBox1.SelectedItem.ToString();


        string[] availableTimes = GetAvailableTimes(selectedService);
        comboBox2.Items.AddRange(availableTimes);
        }

        private string[] GetAvailableTimes(string service)
        {

            List<string> times = new List<string>();
            DateTime startTime = DateTime.Today.AddHours(9); // start from 9am  to 6 pm
            DateTime endTime = DateTime.Today.AddHours(18);

            for (DateTime time = startTime; time < endTime; time = time.AddMinutes(30))
            {

                if (service.Contains("Hair cut") && time.Minute == 0)
                    times.Add(time.ToString("hh:mm tt"));
                else if (service.Contains("Hair colouring") && time.Minute == 0)
                    times.Add(time.ToString("hh:mm tt"));
                else if (service.Contains("Hair styling") && time.Minute == 0)
                    times.Add(time.ToString("hh:mm tt"));
            }

            return times.ToArray();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
