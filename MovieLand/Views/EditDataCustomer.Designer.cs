namespace MovieLand.Views
{
    partial class EditDataCustomer
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
            tbNama = new TextBox();
            tbEmail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            tbAlamat = new TextBox();
            btnSimpan = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // tbNama
            // 
            tbNama.Location = new Point(25, 185);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(368, 27);
            tbNama.TabIndex = 0;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(26, 285);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(367, 27);
            tbEmail.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 154);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 2;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 254);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(544, 254);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 368);
            label4.Name = "label4";
            label4.Size = new Size(74, 28);
            label4.TabIndex = 5;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(544, 154);
            label5.Name = "label5";
            label5.Size = new Size(99, 28);
            label5.TabIndex = 6;
            label5.Text = "Username";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(545, 185);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(367, 27);
            tbUsername.TabIndex = 7;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(544, 285);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(367, 27);
            tbPassword.TabIndex = 8;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(25, 399);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(367, 27);
            tbAlamat.TabIndex = 9;
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(545, 382);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(104, 55);
            btnSimpan.TabIndex = 10;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(26, 40);
            label6.Name = "label6";
            label6.Size = new Size(415, 81);
            label6.TabIndex = 11;
            label6.Text = "EDIT PROFILE";
            // 
            // EditDataCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(label6);
            Controls.Add(btnSimpan);
            Controls.Add(tbAlamat);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbEmail);
            Controls.Add(tbNama);
            Name = "EditDataCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditDataCustomer";
            Load += EditDataCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama;
        private TextBox tbEmail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private TextBox tbAlamat;
        private Button btnSimpan;
        private Label label6;
    }
}