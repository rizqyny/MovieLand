namespace MovieLand.Views
{
    partial class Transaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transaksi));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnSelesai2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(352, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 260);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(430, 363);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 1;
            label1.Text = "SCAN KODE QR";
            // 
            // btnSelesai2
            // 
            btnSelesai2.BackgroundImage = (Image)resources.GetObject("btnSelesai2.BackgroundImage");
            btnSelesai2.ForeColor = SystemColors.ControlLightLight;
            btnSelesai2.Location = new Point(436, 426);
            btnSelesai2.Name = "btnSelesai2";
            btnSelesai2.Size = new Size(101, 35);
            btnSelesai2.TabIndex = 8;
            btnSelesai2.Text = "Selesai";
            btnSelesai2.UseVisualStyleBackColor = true;
            btnSelesai2.Click += btnSelesai2_Click;
            // 
            // Transaksi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(982, 503);
            Controls.Add(btnSelesai2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Transaksi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Transaksi";
            Load += Transaksi_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button btnSelesai2;
    }
}