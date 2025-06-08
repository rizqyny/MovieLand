namespace MovieLand.Views
{
    partial class ManageFilm
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
            lblDataFilm = new Label();
            SuspendLayout();
            // 
            // lblDataFilm
            // 
            lblDataFilm.AutoSize = true;
            lblDataFilm.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataFilm.Location = new Point(440, 50);
            lblDataFilm.Name = "lblDataFilm";
            lblDataFilm.Size = new Size(305, 81);
            lblDataFilm.TabIndex = 1;
            lblDataFilm.Text = "Data FIlm";
            // 
            // ManageFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDataFilm);
            Name = "ManageFilm";
            Size = new Size(1470, 1080);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDataFilm;
    }
}
