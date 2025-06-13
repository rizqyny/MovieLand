namespace MovieLand.Views
{
    partial class CardFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardFilm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelFilm = new Panel();
            lblJudul = new Label();
            pbGambarFilm = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panelFilm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelFilm, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(208, 336);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelFilm
            // 
            panelFilm.BackgroundImage = (Image)resources.GetObject("panelFilm.BackgroundImage");
            panelFilm.Controls.Add(lblJudul);
            panelFilm.Controls.Add(pbGambarFilm);
            panelFilm.Dock = DockStyle.Top;
            panelFilm.Location = new Point(3, 3);
            panelFilm.Name = "panelFilm";
            panelFilm.Size = new Size(202, 330);
            panelFilm.TabIndex = 0;
            panelFilm.Paint += panelFilm_Paint;
            // 
            // lblJudul
            // 
            lblJudul.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblJudul.ForeColor = Color.White;
            lblJudul.Location = new Point(14, 258);
            lblJudul.Name = "lblJudul";
            lblJudul.Size = new Size(168, 57);
            lblJudul.TabIndex = 1;
            lblJudul.Text = " Judul     ";
            // 
            // pbGambarFilm
            // 
            pbGambarFilm.BackgroundImage = (Image)resources.GetObject("pbGambarFilm.BackgroundImage");
            pbGambarFilm.Location = new Point(14, 12);
            pbGambarFilm.Name = "pbGambarFilm";
            pbGambarFilm.Size = new Size(168, 232);
            pbGambarFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            pbGambarFilm.TabIndex = 0;
            pbGambarFilm.TabStop = false;
            // 
            // CardFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "CardFilm";
            Size = new Size(208, 336);
            tableLayoutPanel1.ResumeLayout(false);
            panelFilm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbGambarFilm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelFilm;
        private Label lblJudul;
        private PictureBox pbGambarFilm;
    }
}
