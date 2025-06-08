namespace MovieLand.Views
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            tb_Password = new TextBox();
            tb_Username = new TextBox();
            label2 = new Label();
            btn_Register = new Button();
            label1 = new Label();
            label4 = new Label();
            tb_PasswordConfirm = new TextBox();
            label5 = new Label();
            tb_Email = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // tb_Password
            // 
            tb_Password.Font = new Font("Segoe UI", 12F);
            tb_Password.Location = new Point(1169, 382);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(283, 34);
            tb_Password.TabIndex = 8;
            // 
            // tb_Username
            // 
            tb_Username.Font = new Font("Segoe UI", 12F);
            tb_Username.Location = new Point(1169, 304);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(283, 34);
            tb_Username.TabIndex = 7;
            tb_Username.TextChanged += tb_Username_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(1169, 351);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 10;
            label2.Text = "Password";
            // 
            // btn_Register
            // 
            btn_Register.BackgroundImage = (Image)resources.GetObject("btn_Register.BackgroundImage");
            btn_Register.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Register.ForeColor = Color.White;
            btn_Register.Location = new Point(1169, 628);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(135, 37);
            btn_Register.TabIndex = 11;
            btn_Register.Text = "Register";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(1169, 273);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 9;
            label1.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(1169, 434);
            label4.Name = "label4";
            label4.Size = new Size(191, 28);
            label4.TabIndex = 15;
            label4.Text = "Konfirmasi Password";
            // 
            // tb_PasswordConfirm
            // 
            tb_PasswordConfirm.Font = new Font("Segoe UI", 12F);
            tb_PasswordConfirm.Location = new Point(1169, 465);
            tb_PasswordConfirm.Name = "tb_PasswordConfirm";
            tb_PasswordConfirm.Size = new Size(283, 34);
            tb_PasswordConfirm.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(1169, 513);
            label5.Name = "label5";
            label5.Size = new Size(59, 28);
            label5.TabIndex = 17;
            label5.Text = "Email";
            // 
            // tb_Email
            // 
            tb_Email.Font = new Font("Segoe UI", 12F);
            tb_Email.Location = new Point(1169, 544);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(283, 34);
            tb_Email.TabIndex = 16;
            tb_Email.TextChanged += tb_Email_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1317, 628);
            button1.Name = "button1";
            button1.Size = new Size(135, 37);
            button1.TabIndex = 18;
            button1.Text = "Kembali";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1055);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(tb_Email);
            Controls.Add(label4);
            Controls.Add(tb_PasswordConfirm);
            Controls.Add(btn_Register);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            WindowState = FormWindowState.Maximized;
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tb_Password;
        private TextBox tb_Username;
        private Label label2;
        private Button btn_Register;
        private Label label1;
        private Label label4;
        private TextBox tb_PasswordConfirm;
        private Label label5;
        private TextBox tb_Email;
        private Button button1;
    }
}