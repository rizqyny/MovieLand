namespace MovieLand.Views
{
    partial class RiwayatPemesanan
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
            lblRiwayatPemesanan = new Label();
            SuspendLayout();
            // 
            // lblRiwayatPemesanan
            // 
            lblRiwayatPemesanan.AutoSize = true;
            lblRiwayatPemesanan.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRiwayatPemesanan.Location = new Point(264, 50);
            lblRiwayatPemesanan.Name = "lblRiwayatPemesanan";
            lblRiwayatPemesanan.Size = new Size(591, 81);
            lblRiwayatPemesanan.TabIndex = 2;
            lblRiwayatPemesanan.Text = "Riwayat Pemesanan";
            // 
            // RiwayatPemesanan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblRiwayatPemesanan);
            Name = "RiwayatPemesanan";
            Size = new Size(1470, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRiwayatPemesanan;
    }
}
