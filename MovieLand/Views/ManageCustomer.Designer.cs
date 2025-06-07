namespace MovieLand.Views
{
    partial class ManageCustomer
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
            lblDataCustomer = new Label();
            SuspendLayout();
            // 
            // lblDataCustomer
            // 
            lblDataCustomer.AutoSize = true;
            lblDataCustomer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataCustomer.Location = new Point(440, 50);
            lblDataCustomer.Name = "lblDataCustomer";
            lblDataCustomer.Size = new Size(453, 81);
            lblDataCustomer.TabIndex = 2;
            lblDataCustomer.Text = "Data Customer";
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDataCustomer);
            Name = "ManageCustomer";
            Size = new Size(1470, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDataCustomer;
    }
}
