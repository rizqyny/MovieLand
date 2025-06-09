namespace MovieLand.Views
{
    partial class DashboardCustomer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardCustomer));
            lblDashboardCustomer = new Label();
            SuspendLayout();
            // 
            // lblDashboardCustomer
            // 
            lblDashboardCustomer.AutoSize = true;
            lblDashboardCustomer.BackColor = Color.White;
            lblDashboardCustomer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardCustomer.Location = new Point(183, 50);
            lblDashboardCustomer.Name = "lblDashboardCustomer";
            lblDashboardCustomer.Size = new Size(626, 81);
            lblDashboardCustomer.TabIndex = 1;
            lblDashboardCustomer.Text = "Dashboard Customer";
            // 
            // DashboardCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(lblDashboardCustomer);
            Name = "DashboardCustomer";
            Size = new Size(1470, 1080);
            Load += DashboardCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboardCustomer;
    }
}
