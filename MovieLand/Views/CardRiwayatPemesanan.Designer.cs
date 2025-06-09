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
            pictureBox1 = new PictureBox();
            lblJudul = new Label();
            lblJamTayang = new Label();
            lblNomorKursi = new Label();
            label1 = new Label();
            label2 = new Label();
            lblHarga = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(12, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblJudul
            // 
            lblJudul.AutoSize = true;
            lblJudul.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.Location = new Point(95, 42);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(88, 23);
            lblJudul.TabIndex = 1;
            lblJudul.Text = "Judul Film";
            // 
            // lblJamTayang
            // 
            lblJamTayang.AutoSize = true;
            lblJamTayang.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJamTayang.ForeColor = Color.Navy;
            lblJamTayang.Location = new Point(95, 75);
            lblJamTayang.Name = "lblJamTayang";
            lblJamTayang.Size = new Size(50, 23);
            lblJamTayang.TabIndex = 2;
            lblJamTayang.Text = "00:00";
            // 
            // lblNomorKursi
            // 
            lblNomorKursi.AutoSize = true;
            lblNomorKursi.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomorKursi.Location = new Point(302, 42);
            lblNomorKursi.Name = "lblNomorKursi";
            lblNomorKursi.Size = new Size(17, 23);
            lblNomorKursi.TabIndex = 3;
            lblNomorKursi.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 42);
            label1.Name = "label1";
            label1.Size = new Size(105, 23);
            label1.TabIndex = 4;
            label1.Text = "Nomor kursi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(197, 75);
            label2.Name = "label2";
            label2.Size = new Size(31, 23);
            label2.TabIndex = 5;
            label2.Text = "Rp";
            // 
            // lblHarga
            // 
            lblHarga.AutoSize = true;
            lblHarga.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHarga.Location = new Point(224, 75);
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
            Controls.Add(lblJamTayang);
            Controls.Add(lblJudul);
            Controls.Add(pictureBox1);
            Name = "CardRiwayatPemesanan";
            Size = new Size(350, 128);
            Load += CardRiwayatPemesanan_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblJudul;
        private Label lblJamTayang;
        private Label lblNomorKursi;
        private Label label1;
        private Label label2;
        private Label lblHarga;
    }
}
