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
            btnSimpan = new Button();
            SuspendLayout();
            // 
            // tbNama_lengkap
            // 
            tbNama_lengkap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbNama_lengkap.Location = new Point(732, 254);
            tbNama_lengkap.Name = "tbNama_lengkap";
            tbNama_lengkap.Size = new Size(459, 34);
            tbNama_lengkap.TabIndex = 0;
            tbNama_lengkap.TextChanged += tbNama_lengkap_TextChanged;
            // 
            // tbAlamat
            // 
            tbAlamat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAlamat.Location = new Point(732, 438);
            tbAlamat.Name = "tbAlamat";
            tbAlamat.Size = new Size(459, 34);
            tbAlamat.TabIndex = 1;
            tbAlamat.TextChanged += tbAlamat_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(732, 223);
            label1.Name = "label1";
            label1.Size = new Size(143, 28);
            label1.TabIndex = 2;
            label1.Text = "Nama Lengkap";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(732, 407);
            label2.Name = "label2";
            label2.Size = new Size(74, 28);
            label2.TabIndex = 3;
            label2.Text = "Alamat";
            // 
            // btnSimpan
            // 
            btnSimpan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSimpan.Location = new Point(1084, 572);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(107, 40);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // DataDiri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.MovieLand__1_;
            ClientSize = new Size(1532, 981);
            Controls.Add(btnSimpan);
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
        private Button btnSimpan;
    }
}