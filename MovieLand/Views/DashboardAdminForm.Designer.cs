namespace MovieLand.Views
{
    partial class DashboardAdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdminForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelRight = new Panel();
            panelLeft = new Panel();
            btnLogout = new Button();
            btnManageCustomer = new Button();
            btnManageFilm = new Button();
            tableLayoutPanel1.SuspendLayout();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5446987F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.4553F));
            tableLayoutPanel1.Controls.Add(panelRight, 1, 0);
            tableLayoutPanel1.Controls.Add(panelLeft, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1924, 1055);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelRight
            // 
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(456, 3);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(1465, 1049);
            panelRight.TabIndex = 1;
            // 
            // panelLeft
            // 
            panelLeft.BackgroundImage = (Image)resources.GetObject("panelLeft.BackgroundImage");
            panelLeft.Controls.Add(btnLogout);
            panelLeft.Controls.Add(btnManageCustomer);
            panelLeft.Controls.Add(btnManageFilm);
            panelLeft.Dock = DockStyle.Fill;
            panelLeft.Location = new Point(3, 3);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(447, 1049);
            panelLeft.TabIndex = 2;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.White;
            btnLogout.BackgroundImage = (Image)resources.GetObject("btnLogout.BackgroundImage");
            btnLogout.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(188, 882);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(116, 46);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageCustomer
            // 
            btnManageCustomer.BackColor = Color.White;
            btnManageCustomer.BackgroundImage = (Image)resources.GetObject("btnManageCustomer.BackgroundImage");
            btnManageCustomer.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageCustomer.ForeColor = Color.White;
            btnManageCustomer.Location = new Point(138, 471);
            btnManageCustomer.Name = "btnManageCustomer";
            btnManageCustomer.Size = new Size(222, 46);
            btnManageCustomer.TabIndex = 2;
            btnManageCustomer.Text = "Manage Customer";
            btnManageCustomer.UseVisualStyleBackColor = false;
            btnManageCustomer.Click += btnManageCustomer_Click;
            // 
            // btnManageFilm
            // 
            btnManageFilm.BackColor = Color.White;
            btnManageFilm.BackgroundImage = (Image)resources.GetObject("btnManageFilm.BackgroundImage");
            btnManageFilm.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageFilm.ForeColor = Color.White;
            btnManageFilm.Location = new Point(138, 388);
            btnManageFilm.Name = "btnManageFilm";
            btnManageFilm.Size = new Size(222, 46);
            btnManageFilm.TabIndex = 1;
            btnManageFilm.Text = "Manage Film";
            btnManageFilm.UseVisualStyleBackColor = false;
            btnManageFilm.Click += btnManageFilm_Click;
            // 
            // DashboardAdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardAdminForm";
            Text = "DashboardAdmin";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelRight;
        private Panel panelLeft;
        private Button btnLogout;
        private Button btnManageCustomer;
        private Button btnManageFilm;
    }
}