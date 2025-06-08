namespace MovieLand.Views
{
    partial class DashboardAdmin
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
            lblDashboardAdmin = new Label();
            SuspendLayout();
            // 
            // lblDashboardAdmin
            // 
            lblDashboardAdmin.AutoSize = true;
            lblDashboardAdmin.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDashboardAdmin.Location = new Point(440, 50);
            lblDashboardAdmin.Name = "lblDashboardAdmin";
            lblDashboardAdmin.Size = new Size(543, 81);
            lblDashboardAdmin.TabIndex = 0;
            lblDashboardAdmin.Text = "Dashboard Admin";
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDashboardAdmin);
            Name = "DashboardAdmin";
            Size = new Size(1470, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDashboardAdmin;
    }
}
