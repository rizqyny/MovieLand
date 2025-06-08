namespace MovieLand.Views
{
    partial class DataDiri
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
            tbNama_lengkap = new TextBox();
            tbAlamat = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // tbNama_lengkap
            // 
            tbNama_lengkap.Location = new Point(102, 162);
            tbNama_lengkap.Name = "tbNama_lengkap";
            tbNama_lengkap.Size = new Size(341, 27);
            tbNama_lengkap.TabIndex = 0;
            tbNama_lengkap.TextChanged += tbNama_lengkap_TextChanged;
            // 
            // tbAlamat
            // 
            tbAlamat.Location = new Point(102, 260);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(341, 27);
            tbAlamat.TabIndex = 1;
            tbAlamat.TextChanged += tbAlamat_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 139);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 2;
            label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 237);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Alamat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 63);
            label3.Name = "label3";
            label3.Size = new Size(151, 41);
            label3.TabIndex = 4;
            label3.Text = "DATA DIRI";
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(632, 228);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // DataDiri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSimpan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbAlamat);
            Controls.Add(tbNama_lengkap);
            Name = "DataDiri";
            Text = "DataDiri";
            Load += DataDiri_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNama_lengkap;
        private TextBox tbAlamat;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSimpan;
    }
}