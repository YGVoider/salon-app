using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace salon_app
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {



            string filePath = Path.Combine(Application.StartupPath, "booking_data.txt");



            if (File.Exists(filePath))
            {
                richTextBox1.Text = File.ReadAllText(filePath);
            }
            else
            {
                richTextBox1.Text = "No booking history found.\nFile missing:\n" + filePath;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
            
}

