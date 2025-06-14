namespace MovieLand.Views
{
    partial class EditCustomerMelaluiAdmin
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
            btnSimpan = new Button();
            txtNama = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtAlamat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(578, 396);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 0;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // txtNama
            // 
            txtNama.Location = new Point(95, 171);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(301, 27);
            txtNama.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(95, 284);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(301, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(578, 171);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(301, 27);
            txtUsername.TabIndex = 3;
            
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(578, 284);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(301, 27);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(95, 398);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(301, 27);
            txtAlamat.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 148);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 261);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 375);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 9;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(578, 261);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Password";
            
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(578, 148);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 11;
            label6.Text = "Username";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(95, 62);
            label3.Name = "label3";
            label3.Size = new Size(312, 50);
            label3.TabIndex = 12;
            label3.Text = "EDIT CUSTOMER";
            // 
            // EditCustomerMelaluiAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAlamat);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(txtNama);
            Controls.Add(btnSimpan);
            Name = "EditCustomerMelaluiAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditCustomerMelaluiAdmin";
            Load += EditCustomerMelaluiAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSimpan;
        private TextBox txtNama;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtAlamat;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label3;
    }
}