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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageFilm));
            lblDataFilm = new Label();
            dgvFilm = new DataGridView();
            btnTambahFilm = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFilm).BeginInit();
            SuspendLayout();
            // 
            // lblDataFilm
            // 
            lblDataFilm.AutoSize = true;
            lblDataFilm.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataFilm.ForeColor = Color.Black;
            lblDataFilm.Location = new Point(565, 50);
            lblDataFilm.Name = "lblDataFilm";
            lblDataFilm.Size = new Size(305, 81);
            lblDataFilm.TabIndex = 1;
            lblDataFilm.Text = "Data FIlm";
            // 
            // dgvFilm
            // 
            dgvFilm.BackgroundColor = Color.CornflowerBlue;
            dgvFilm.BorderStyle = BorderStyle.Fixed3D;
            dgvFilm.ColumnHeadersHeight = 40;
            dgvFilm.Location = new Point(177, 159);
            dgvFilm.Name = "dgvFilm";
            dgvFilm.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvFilm.Size = new Size(1103, 633);
            dgvFilm.TabIndex = 2;
            dgvFilm.CellContentClick += dgvFilm_CellContentClick;
            // 
            // btnTambahFilm
            // 
            btnTambahFilm.BackColor = Color.Black;
            btnTambahFilm.BackgroundImage = (Image)resources.GetObject("btnTambahFilm.BackgroundImage");
            btnTambahFilm.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahFilm.ForeColor = Color.White;
            btnTambahFilm.Location = new Point(597, 856);
            btnTambahFilm.Name = "btnTambahFilm";
            btnTambahFilm.Size = new Size(237, 61);
            btnTambahFilm.TabIndex = 3;
            btnTambahFilm.Text = "Tambah Data Film";
            btnTambahFilm.UseVisualStyleBackColor = false;
            btnTambahFilm.Click += btnTambahFilm_Click;
            // 
            // ManageFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTambahFilm);
            Controls.Add(dgvFilm);
            Controls.Add(lblDataFilm);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "ManageFilm";
            Size = new Size(1470, 1080);
            Load += ManageFilm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDataFilm;
        private DataGridView dgvFilm;
        private Button btnTambahFilm;
    }
}
