namespace MovieLand.Views
{
    partial class DashboardCustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardCustomerForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelLeft = new Panel();
            btnLogout = new Button();
            btnProfile = new Button();
            btnRiwayatPemesanan = new Button();
            btnDashboard = new Button();
            panelRight = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5446987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.4553F));
            tableLayoutPanel1.Controls.Add(panelLeft, 0, 0);
            tableLayoutPanel1.Controls.Add(panelRight, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1924, 1055);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.BackgroundImage = (Image)resources.GetObject("panelLeft.BackgroundImage");
            panelLeft.Controls.Add(btnLogout);
            panelLeft.Controls.Add(btnProfile);
            panelLeft.Controls.Add(btnRiwayatPemesanan);
            panelLeft.Controls.Add(btnDashboard);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(3, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(447, 1049);
            panelLeft.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(183, 882);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(116, 46);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.White;
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(134, 558);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(248, 46);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click_1;
            // 
            // btnRiwayatPemesanan
            // 
            btnRiwayatPemesanan.BackColor = Color.White;
            btnRiwayatPemesanan.BackgroundImage = (Image)resources.GetObject("btnRiwayatPemesanan.BackgroundImage");
            btnRiwayatPemesanan.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRiwayatPemesanan.ForeColor = Color.White;
            btnRiwayatPemesanan.Location = new Point(134, 474);
            btnRiwayatPemesanan.Name = "btnRiwayatPemesanan";
            btnRiwayatPemesanan.Size = new Size(248, 46);
            btnRiwayatPemesanan.TabIndex = 2;
            btnRiwayatPemesanan.Text = "Riwayat Pemesanan";
            btnRiwayatPemesanan.UseVisualStyleBackColor = false;
            btnRiwayatPemesanan.Click += btnRiwayatPemesanan_Click_1;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.BackgroundImage = (Image)resources.GetObject("btnDashboard.BackgroundImage");
            btnDashboard.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(134, 389);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(248, 46);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // panelRight
            // 
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(456, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(1465, 1049);
            panelRight.TabIndex = 1;
            // 
            // DashboardCustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardCustomerForm";
            Text = "DashboardCustomer";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelLeft;
        private Button btnProfile;
        private Button btnRiwayatPemesanan;
        private Button btnDashboard;
        private Panel panelRight;
        private Button btnLogout;
    }
}