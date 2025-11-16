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
    public partial class Dashboard : Form
    {
        bool menuExpand = false;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Menu should start hidden
            panelMenu.Width = 0;
            menuExpand = false;
        }

        private void menuTimer_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                panelMenu.Width +=4;
                if (panelMenu.Width >= 150)
                {
                    menuTimer.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width <= 0)
                {
                    menuTimer.Stop();
                    menuExpand = false;
                }
            }

        }

        private void Menu_Click(object sender, EventArgs e)
        {
            menuTimer.Start();
        }
    }
}
