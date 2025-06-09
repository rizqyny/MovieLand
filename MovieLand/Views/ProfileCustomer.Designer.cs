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
            lblNama = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblAlamat = new Label();
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
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Location = new Point(290, 178);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(50, 20);
            lblNama.TabIndex = 3;
            lblNama.Text = "label1";
            lblNama.Click += lblNama_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(290, 240);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "label1";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(290, 301);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(50, 20);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "label2";
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Location = new Point(290, 355);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(50, 20);
            lblAlamat.TabIndex = 6;
            lblAlamat.Text = "label3";
            // 
            // ProfileCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblAlamat);
            Controls.Add(lblUsername);
            Controls.Add(lblEmail);
            Controls.Add(lblNama);
            Controls.Add(lblProfile);
            Name = "ProfileCustomer";
            Size = new Size(1470, 1080);
            Load += ProfileCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProfile;
        private Label lblNama;
        private Label lblEmail;
        private Label lblUsername;
        private Label lblAlamat;
    }
}
