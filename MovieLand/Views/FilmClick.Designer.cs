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
            pictureBox1 = new PictureBox();
            lbl_Judul = new Label();
            lbl_Kategori = new Label();
            lbl_Durasi = new Label();
            button1 = new Button();
            button2 = new Button();
            lbl_Harga = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(435, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 154);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            lbl_Kategori.Location = new Point(473, 224);
            lbl_Kategori.Name = "lbl_Kategori";
            lbl_Kategori.Size = new Size(55, 23);
            lbl_Kategori.TabIndex = 2;
            lbl_Kategori.Text = "label2";
            // 
            // lbl_Durasi
            // 
            lbl_Durasi.AutoSize = true;
            lbl_Durasi.Font = new Font("Segoe UI", 10F);
            lbl_Durasi.Location = new Point(473, 263);
            lbl_Durasi.Name = "lbl_Durasi";
            lbl_Durasi.Size = new Size(55, 23);
            lbl_Durasi.TabIndex = 3;
            lbl_Durasi.Text = "label3";
            // 
            // button1
            // 
            button1.Location = new Point(382, 358);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Pesan ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(504, 358);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Kembali";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbl_Harga
            // 
            lbl_Harga.AutoSize = true;
            lbl_Harga.Font = new Font("Segoe UI", 10F);
            lbl_Harga.Location = new Point(473, 297);
            lbl_Harga.Name = "lbl_Harga";
            lbl_Harga.Size = new Size(55, 23);
            lbl_Harga.TabIndex = 6;
            lbl_Harga.Text = "label4";
            // 
            // FilmClick
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(lbl_Harga);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_Durasi);
            Controls.Add(lbl_Kategori);
            Controls.Add(lbl_Judul);
            Controls.Add(pictureBox1);
            Name = "FilmClick";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FilmClick";
            Load += FilmClick_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_Judul;
        private Label lbl_Kategori;
        private Label lbl_Durasi;
        private Button button1;
        private Button button2;
        private Label lbl_Harga;
    }
}