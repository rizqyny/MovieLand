namespace MovieLand.Views
{
    partial class EditFilm
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
            tbJudul = new TextBox();
            tbDurasi = new TextBox();
            label1 = new Label();
            tbDeskripsi = new TextBox();
            tbHarga = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbGambar = new TextBox();
            label6 = new Label();
            tbKategori = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // tbJudul
            // 
            tbJudul.Location = new Point(114, 31);
            tbJudul.Name = "tbJudul";
            tbJudul.Size = new Size(125, 27);
            tbJudul.TabIndex = 0;
            // 
            // tbDurasi
            // 
            tbDurasi.Location = new Point(114, 81);
            tbDurasi.Name = "tbDurasi";
            tbDurasi.Size = new Size(125, 27);
            tbDurasi.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "Judul:";
            // 
            // tbDeskripsi
            // 
            tbDeskripsi.Location = new Point(114, 131);
            tbDeskripsi.Name = "tbDeskripsi";
            tbDeskripsi.Size = new Size(816, 27);
            tbDeskripsi.TabIndex = 3;
            // 
            // tbHarga
            // 
            tbHarga.Location = new Point(114, 212);
            tbHarga.Name = "tbHarga";
            tbHarga.Size = new Size(125, 27);
            tbHarga.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 84);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 5;
            label2.Text = "Durasi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 131);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "Deskripsi:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 215);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Harga:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 264);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 9;
            label5.Text = "Gambar:";
            // 
            // tbGambar
            // 
            tbGambar.Location = new Point(114, 261);
            tbGambar.Name = "tbGambar";
            tbGambar.Size = new Size(125, 27);
            tbGambar.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 312);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 11;
            label6.Text = "Kategori:";
            // 
            // tbKategori
            // 
            tbKategori.Location = new Point(114, 309);
            tbKategori.Name = "tbKategori";
            tbKategori.Size = new Size(125, 27);
            tbKategori.TabIndex = 10;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(661, 410);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(774, 410);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 13;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // EditFilm
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
            Name = "EditFilm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            Load += EditFilm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbJudul;
        private TextBox tbDurasi;
        private Label label1;
        private TextBox tbDeskripsi;
        private TextBox tbHarga;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbGambar;
        private Label label6;
        private TextBox tbKategori;
        private Button btnSimpan;
        private Button btnBatal;
    }
}