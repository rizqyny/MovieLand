namespace MovieLand.Views
{
    partial class TambahFilm
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
            btnBatal = new Button();
            btnSimpan = new Button();
            label6 = new Label();
            tbKategori = new TextBox();
            label5 = new Label();
            tbGambar = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbHarga = new TextBox();
            tbDeskripsi = new TextBox();
            label1 = new Label();
            tbDurasi = new TextBox();
            tbJudul = new TextBox();
            SuspendLayout();
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(784, 426);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 27;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(671, 426);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 26;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 328);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 25;
            label6.Text = "Kategori:";
            // 
            // tbKategori
            // 
            tbKategori.Location = new Point(124, 325);
            tbKategori.Name = "tbKategori";
            tbKategori.Size = new Size(125, 27);
            tbKategori.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 280);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 23;
            label5.Text = "Gambar:";
            // 
            // tbGambar
            // 
            tbGambar.Location = new Point(124, 277);
            tbGambar.Name = "tbGambar";
            tbGambar.Size = new Size(125, 27);
            tbGambar.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 231);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 21;
            label4.Text = "Harga:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 147);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 20;
            label3.Text = "Deskripsi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 100);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 19;
            label2.Text = "Durasi:";
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(124, 228);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(125, 27);
            tbHarga.TabIndex = 18;
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Location = new Point(124, 147);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(816, 27);
            tbDeskripsi.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 16;
            label1.Text = "Judul:";
            // 
            // tbDurasi
            // 
            tbDurasi.Location = new Point(124, 97);
            tbDurasi.Name = "tbDurasi";
            tbDurasi.Size = new Size(125, 27);
            tbDurasi.TabIndex = 15;
            // 
            // tbJudul
            // 
            tbJudul.Location = new Point(124, 47);
            tbJudul.Name = "tbJudul";
            tbJudul.Size = new Size(125, 27);
            tbJudul.TabIndex = 14;
            // 
            // TambahFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(label6);
            Controls.Add(tbKategori);
            Controls.Add(label5);
            Controls.Add(tbGambar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbHarga);
            Controls.Add(tbDeskripsi);
            Controls.Add(label1);
            Controls.Add(tbDurasi);
            Controls.Add(tbJudul);
            Name = "TambahFilm";
            Text = "TambahFilm";
            Load += TambahFilm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBatal;
        private Button btnSimpan;
        private Label label6;
        private TextBox tbKategori;
        private Label label5;
        private TextBox tbGambar;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbHarga;
        private TextBox tbDeskripsi;
        private Label label1;
        private TextBox tbDurasi;
        private TextBox tbJudul;
    }
}