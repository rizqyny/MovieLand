namespace MovieLand.Views
{
    partial class FilmClick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmClick));
            pb_Poster = new PictureBox();
            lbl_Judul = new Label();
            lbl_Kategori = new Label();
            lbl_Durasi = new Label();
            lbl_Harga = new Label();
            btn_Pesan2 = new Button();
            btnKembali2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_Poster).BeginInit();
            SuspendLayout();
            // 
            // pb_Poster
            // 
            pb_Poster.Location = new Point(435, 12);
            pb_Poster.Name = "pb_Poster";
            pb_Poster.Size = new Size(125, 154);
            pb_Poster.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_Poster.TabIndex = 0;
            pb_Poster.TabStop = false;
            // 
            // lbl_Judul
            // 
            lbl_Judul.AutoSize = true;
            lbl_Judul.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Judul.Location = new Point(465, 183);
            lbl_Judul.Name = "lbl_Judul";
            lbl_Judul.Size = new Size(63, 25);
            lbl_Judul.TabIndex = 1;
            lbl_Judul.Text = "label1";
            // 
            // lbl_Kategori
            // 
            lbl_Kategori.AutoSize = true;
            lbl_Kategori.Font = new Font("Segoe UI", 10F);
            lbl_Kategori.Location = new Point(465, 224);
            lbl_Kategori.Name = "lbl_Kategori";
            lbl_Kategori.Size = new Size(55, 23);
            lbl_Kategori.TabIndex = 2;
            lbl_Kategori.Text = "label2";
            // 
            // lbl_Durasi
            // 
            lbl_Durasi.AutoSize = true;
            lbl_Durasi.Font = new Font("Segoe UI", 10F);
            lbl_Durasi.Location = new Point(465, 260);
            lbl_Durasi.Name = "lbl_Durasi";
            lbl_Durasi.Size = new Size(55, 23);
            lbl_Durasi.TabIndex = 3;
            lbl_Durasi.Text = "label3";
            // 
            // lbl_Harga
            // 
            lbl_Harga.AutoSize = true;
            lbl_Harga.Font = new Font("Segoe UI", 10F);
            lbl_Harga.Location = new Point(465, 294);
            lbl_Harga.Name = "lbl_Harga";
            lbl_Harga.Size = new Size(55, 23);
            lbl_Harga.TabIndex = 6;
            lbl_Harga.Text = "label4";
            // 
            // btn_Pesan2
            // 
            btn_Pesan2.BackgroundImage = (Image)resources.GetObject("btn_Pesan2.BackgroundImage");
            btn_Pesan2.ForeColor = SystemColors.ControlLightLight;
            btn_Pesan2.Location = new Point(371, 372);
            btn_Pesan2.Name = "btn_Pesan2";
            btn_Pesan2.Size = new Size(101, 35);
            btn_Pesan2.TabIndex = 7;
            btn_Pesan2.Text = "Pesan";
            btn_Pesan2.UseVisualStyleBackColor = true;
            btn_Pesan2.Click += btn_Pesan2_Click;
            // 
            // btnKembali2
            // 
            btnKembali2.BackgroundImage = (Image)resources.GetObject("btnKembali2.BackgroundImage");
            btnKembali2.ForeColor = SystemColors.ControlLightLight;
            btnKembali2.Location = new Point(518, 372);
            btnKembali2.Name = "btnKembali2";
            btnKembali2.Size = new Size(101, 35);
            btnKembali2.TabIndex = 8;
            btnKembali2.Text = "Kembali";
            btnKembali2.UseVisualStyleBackColor = true;
            btnKembali2.Click += btnKembali2_Click;
            // 
            // FilmClick
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 503);
            Controls.Add(btnKembali2);
            Controls.Add(btn_Pesan2);
            Controls.Add(lbl_Harga);
            Controls.Add(lbl_Durasi);
            Controls.Add(lbl_Kategori);
            Controls.Add(lbl_Judul);
            Controls.Add(pb_Poster);
            Name = "FilmClick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilmClick";
            Load += FilmClick_Load;
            ((System.ComponentModel.ISupportInitialize)pb_Poster).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_Poster;
        private Label lbl_Judul;
        private Label lbl_Kategori;
        private Label lbl_Durasi;
        private Label lbl_Harga;
        private Button btn_Pesan2;
        private Button btnKembali2;
    }
}