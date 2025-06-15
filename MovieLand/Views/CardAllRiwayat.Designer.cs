namespace MovieLand.Views
{
    partial class CardAllRiwayat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardAllRiwayat));
            lblWaktu = new Label();
            lblHarga = new Label();
            lblNomorKursi = new Label();
            lblJudul = new Label();
            pbGambarFilm = new PictureBox();
            lblNamaCustomer = new Label();
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).BeginInit();
            SuspendLayout();
            // 
            // lblWaktu
            // 
            lblWaktu.AutoSize = true;
            lblWaktu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaktu.Location = new Point(95, 92);
            lblWaktu.Name = "lblWaktu";
            lblWaktu.Size = new Size(153, 23);
            lblWaktu.TabIndex = 12;
            lblWaktu.Text = "00-00-0000 (00:00)";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(267, 92);
            lblHarga.Name = "lblHarga";
            lblHarga.Size = new Size(79, 23);
            lblHarga.TabIndex = 11;
            lblHarga.Text = "Rp 10000";
            // 
            // lblNomorKursi
            // 
            lblNomorKursi.AutoSize = true;
            lblNomorKursi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomorKursi.Location = new Point(267, 58);
            lblNomorKursi.Name = "lblNomorKursi";
            lblNomorKursi.Size = new Size(126, 23);
            lblNomorKursi.TabIndex = 10;
            lblNomorKursi.Text = "Nomor kursi : 1";
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(95, 54);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(105, 28);
            lblJudul.TabIndex = 9;
            lblJudul.Text = "Judul Film";
            // 
            // pbGambarFilm
            // 
            pbGambarFilm.BackgroundImage = (Image)resources.GetObject("pbGambarFilm.BackgroundImage");
            pbGambarFilm.Location = new Point(12, 45);
            pbGambarFilm.Name = "pbGambarFilm";
            pbGambarFilm.Size = new Size(65, 86);
            pbGambarFilm.SizeMode = PictureBoxSizeMode.CenterImage;
            pbGambarFilm.TabIndex = 8;
            pbGambarFilm.TabStop = false;
            // 
            // lblNamaCustomer
            // 
            lblNamaCustomer.AutoSize = true;
            lblNamaCustomer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNamaCustomer.Location = new Point(9, 8);
            lblNamaCustomer.Name = "lblNamaCustomer";
            lblNamaCustomer.Size = new Size(271, 28);
            lblNamaCustomer.TabIndex = 13;
            lblNamaCustomer.Text = "Nama Lengkap  (username)";
            lblNamaCustomer.Click += lblNamaCustomer_Click;
            // 
            // CardAllRiwayat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblNamaCustomer);
            Controls.Add(lblWaktu);
            Controls.Add(lblHarga);
            Controls.Add(lblNomorKursi);
            Controls.Add(lblJudul);
            Controls.Add(pbGambarFilm);
            Name = "CardAllRiwayat";
            Size = new Size(405, 141);
            Load += CardAllRiwayat_Load;
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWaktu;
        private Label lblHarga;
        private Label lblNomorKursi;
        private Label lblJudul;
        private PictureBox pbGambarFilm;
        private Label lblNamaCustomer;
    }
}
