﻿namespace MovieLand.Views
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileCustomer));
            lblProfile = new Label();
            lblNama = new Label();
            lblEmail = new Label();
            lblUsername = new Label();
            lblAlamat = new Label();
            lblPassword = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnEdit = new Button();
            SuspendLayout();
            // 
            // lblProfile
            // 
            lblProfile.AutoSize = true;
            lblProfile.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfile.Location = new Point(264, 50);
            lblProfile.Name = "lblProfile";
            lblProfile.Size = new Size(0, 81);
            lblProfile.TabIndex = 2;
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNama.Location = new Point(344, 307);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(86, 28);
            lblNama.TabIndex = 3;
            lblNama.Text = "lblNama";
            lblNama.Click += lblNama_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(344, 421);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(81, 28);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "lblEmail";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(727, 307);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(121, 28);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "lblUsername";
            lblUsername.Click += lblUsername_Click;
            // 
            // lblAlamat
            // 
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlamat.Location = new Point(344, 534);
            lblAlamat.Name = "lblAlamat";
            lblAlamat.Size = new Size(96, 28);
            lblAlamat.TabIndex = 6;
            lblAlamat.Text = "lblAlamat";
            lblAlamat.Click += lblAlamat_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(727, 421);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(115, 28);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "lblPassword";
            lblPassword.Click += lblPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 279);
            label1.Name = "label1";
            label1.Size = new Size(73, 28);
            label1.TabIndex = 8;
            label1.Text = "Nama :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(344, 393);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 9;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(344, 506);
            label3.Name = "label3";
            label3.Size = new Size(83, 28);
            label3.TabIndex = 10;
            label3.Text = "Alamat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(727, 279);
            label4.Name = "label4";
            label4.Size = new Size(108, 28);
            label4.TabIndex = 11;
            label4.Text = "Username :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(727, 393);
            label5.Name = "label5";
            label5.Size = new Size(102, 28);
            label5.TabIndex = 12;
            label5.Text = "Password :";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.White;
            btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            btnEdit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(727, 617);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(196, 46);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit Data";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // ProfileCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btnEdit);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblPassword);
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
        private Label lblPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnEdit;
    }
}
