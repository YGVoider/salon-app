namespace salon_app
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelTop = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnBookingHistory = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuTimer = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTop.Controls.Add(this.Menu);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1340, 100);
            this.panelTop.TabIndex = 0;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.DarkGray;
            this.Menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.Location = new System.Drawing.Point(45, 22);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(70, 62);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "☰";
            this.Menu.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel1.Controls.Add(this.btnServices);
            this.flowLayoutPanel1.Controls.Add(this.btnBookings);
            this.flowLayoutPanel1.Controls.Add(this.btnBookingHistory);
            this.flowLayoutPanel1.Controls.Add(this.btnProfile);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(310, 597);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnServices
            // 
            this.btnServices.Location = new System.Drawing.Point(3, 3);
            this.btnServices.Name = "btnServices";
            this.btnServices.Size = new System.Drawing.Size(307, 109);
            this.btnServices.TabIndex = 0;
            this.btnServices.Text = "Services We Offer";
            this.btnServices.UseVisualStyleBackColor = true;
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(3, 118);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(307, 104);
            this.btnBookings.TabIndex = 1;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = true;
            // 
            // btnBookingHistory
            // 
            this.btnBookingHistory.Location = new System.Drawing.Point(3, 228);
            this.btnBookingHistory.Name = "btnBookingHistory";
            this.btnBookingHistory.Size = new System.Drawing.Size(307, 114);
            this.btnBookingHistory.TabIndex = 2;
            this.btnBookingHistory.Text = "Booking History";
            this.btnBookingHistory.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Location = new System.Drawing.Point(3, 348);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(307, 118);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 472);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(307, 113);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // menuTimer
            // 
            this.menuTimer.Interval = 10;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(149)))), ((int)(((byte)(149)))));
            this.ClientSize = new System.Drawing.Size(1340, 697);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hair Salon Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelTop.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnBookingHistory;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer menuTimer;
    }
}