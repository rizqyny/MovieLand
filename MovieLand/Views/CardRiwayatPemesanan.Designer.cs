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
            label1 = new Label();
            label2 = new Label();
            lblHarga = new Label();
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).BeginInit();
            SuspendLayout();
            // 
            // pbGambarFilm
            // 
            pbGambarFilm.BackgroundImage = (Image)resources.GetObject("pbGambarFilm.BackgroundImage");
            pbGambarFilm.Location = new Point(12, 33);
            pbGambarFilm.Name = "pbGambarFilm";
            pbGambarFilm.Size = new Size(65, 83);
            pbGambarFilm.SizeMode = PictureBoxSizeMode.CenterImage;
            pbGambarFilm.TabIndex = 0;
            pbGambarFilm.TabStop = false;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(95, 56);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(88, 23);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Judul Film";
            // 
            // lblNomorKursi
            // 
            lblNomorKursi.AutoSize = true;
            lblNomorKursi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomorKursi.Location = new Point(348, 42);
            lblNomorKursi.Name = "lblNomorKursi";
            lblNomorKursi.Size = new Size(17, 23);
            lblNomorKursi.TabIndex = 3;
            lblNomorKursi.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(229, 42);
            label1.Name = "label1";
            label1.Size = new Size(114, 23);
            label1.TabIndex = 4;
            label1.Text = "Nomor kursi :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(229, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 23);
            label2.TabIndex = 5;
            label2.Text = "Rp :";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(270, 75);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(53, 23);
            lblHarga.TabIndex = 6;
            lblHarga.Text = "10000";
            // 
            // CardRiwayatPemesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblHarga);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNomorKursi);
            Controls.Add(lblJudul);
            Controls.Add(pbGambarFilm);
            Name = "CardRiwayatPemesanan";
            Size = new Size(374, 128);
            Load += CardRiwayatPemesanan_Load;
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGambarFilm;
        private Label lblJudul;
        private Label lblNomorKursi;
        private Label label1;
        private Label label2;
        private Label lblHarga;
    }
}
