namespace MovieLand.Views
{
    partial class ProfileCustomer
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
            lblProfile = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfile.Location = new Point(264, 50);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(221, 81);
            lblProfile.TabIndex = 2;
            lblProfile.Text = "Profile";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(528, 386);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 36);
            textBox1.TabIndex = 4;
            // 
            // ProfileCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox1);
            Controls.Add(lblProfile);
            Name = "ProfileCustomer";
            Size = new Size(1470, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProfile;
        private TextBox textBox1;
    }
}
