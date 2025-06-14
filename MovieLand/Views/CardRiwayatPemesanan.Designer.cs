namespace MovieLand.Views
{
    partial class CardRiwayatPemesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardRiwayatPemesanan));
            pbGambarFilm = new PictureBox();
            lblJudul = new Label();
            lblNomorKursi = new Label();
            lblHarga = new Label();
            lblWaktu = new Label();
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).BeginInit();
            SuspendLayout();
            // 
            // pbGambarFilm
            // 
            pbGambarFilm.BackgroundImage = (Image)resources.GetObject("pbGambarFilm.BackgroundImage");
            pbGambarFilm.Location = new Point(12, 11);
            pbGambarFilm.Name = "pbGambarFilm";
            pbGambarFilm.Size = new Size(65, 86);
            pbGambarFilm.SizeMode = PictureBoxSizeMode.CenterImage;
            pbGambarFilm.TabIndex = 0;
            pbGambarFilm.TabStop = false;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(95, 20);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(105, 28);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Judul Film";
            // 
            // lblNomorKursi
            // 
            lblNomorKursi.AutoSize = true;
            lblNomorKursi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomorKursi.Location = new Point(264, 24);
            lblNomorKursi.Name = "lblNomorKursi";
            lblNomorKursi.Size = new Size(126, 23);
            lblNomorKursi.TabIndex = 3;
            lblNomorKursi.Text = "Nomor kursi : 1";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(264, 58);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(79, 23);
            lblHarga.TabIndex = 6;
            lblHarga.Text = "Rp 10000";
            // 
            // lblWaktu
            // 
            lblWaktu.AutoSize = true;
            lblWaktu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaktu.Location = new Point(95, 58);
            lblWaktu.Name = "lblWaktu";
            lblWaktu.Size = new Size(153, 23);
            lblWaktu.TabIndex = 7;
            lblWaktu.Text = "00-00-0000 (00:00)";
            // 
            // CardRiwayatPemesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblWaktu);
            Controls.Add(lblHarga);
            Controls.Add(lblNomorKursi);
            Controls.Add(lblJudul);
            Controls.Add(pbGambarFilm);
            Name = "CardRiwayatPemesanan";
            Size = new Size(406, 108);
            Load += CardRiwayatPemesanan_Load;
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGambarFilm;
        private Label lblJudul;
        private Label lblNomorKursi;
        private Label lblHarga;
        private Label lblWaktu;
    }
}
