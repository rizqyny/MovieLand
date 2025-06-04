namespace MovieLand.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tb_Username = new TextBox();
            tb_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_Login = new Button();
            label3 = new Label();
            label_Register = new LinkLabel();
            SuspendLayout();
            // 
            // tb_Username
            // 
            tb_Username.Font = new Font("Segoe UI", 12F);
            tb_Username.Location = new Point(1159, 372);
            tb_Username.Name = "tb_Username";
            tb_Username.Size = new Size(283, 34);
            tb_Username.TabIndex = 0;
            // 
            // tb_Password
            // 
            tb_Password.Font = new Font("Segoe UI", 12F);
            tb_Password.Location = new Point(1159, 480);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(283, 34);
            tb_Password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(1159, 341);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(1159, 449);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btn_Login
            // 
            btn_Login.BackgroundImage = (Image)resources.GetObject("btn_Login.BackgroundImage");
            btn_Login.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Login.ForeColor = Color.White;
            btn_Login.Location = new Point(1242, 571);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(135, 37);
            btn_Login.TabIndex = 4;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(1175, 644);
            label3.Name = "label3";
            label3.Size = new Size(181, 28);
            label3.TabIndex = 5;
            label3.Text = "Belum punya akun?";
            // 
            // label_Register
            // 
            label_Register.AutoSize = true;
            label_Register.BackColor = Color.White;
            label_Register.Font = new Font("Segoe UI", 12F);
            label_Register.Location = new Point(1349, 644);
            label_Register.Name = "label_Register";
            label_Register.Size = new Size(82, 28);
            label_Register.TabIndex = 6;
            label_Register.TabStop = true;
            label_Register.Text = "Register";
            label_Register.LinkClicked += label_Register_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1924, 1055);
            Controls.Add(label_Register);
            Controls.Add(label3);
            Controls.Add(btn_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tb_Password);
            Controls.Add(tb_Username);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LandingPage";
            Load += LandingPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_Username;
        private TextBox tb_Password;
        private Label label1;
        private Label label2;
        private Button btn_Login;
        private Label label3;
        private LinkLabel label_Register;
    }
}