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
            btnTambahFilm = new Button();
            btnEdit = new Button();
            button1 = new Button();
            dgvFilm = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvFilm).BeginInit();
            SuspendLayout();
            // 
            // btnTambahFilm
            // 
            btnTambahFilm.BackColor = Color.Black;
            btnTambahFilm.BackgroundImage = (Image)resources.GetObject("btnTambahFilm.BackgroundImage");
            btnTambahFilm.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambahFilm.ForeColor = Color.White;
            btnTambahFilm.Location = new Point(557, 856);
            btnTambahFilm.Name = "btnTambahFilm";
            btnTambahFilm.Size = new Size(237, 61);
            btnTambahFilm.TabIndex = 3;
            btnTambahFilm.Text = "Tambah Data Film";
            btnTambahFilm.UseVisualStyleBackColor = false;
            btnTambahFilm.Click += btnTambahFilm_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Black;
            btnEdit.BackgroundImage = (Image)resources.GetObject("btnEdit.BackgroundImage");
            btnEdit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(800, 856);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(237, 61);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit Data Film";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1043, 856);
            button1.Name = "button1";
            button1.Size = new Size(237, 61);
            button1.TabIndex = 5;
            button1.Text = "Hapus Data Film";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvFilm
            // 
            dgvFilm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFilm.Location = new Point(207, 221);
            dgvFilm.Name = "dgvFilm";
            dgvFilm.RowHeadersWidth = 51;
            dgvFilm.Size = new Size(953, 550);
            dgvFilm.TabIndex = 6;
            // 
            // ManageFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(dgvFilm);
            Controls.Add(button1);
            Controls.Add(btnEdit);
            Controls.Add(btnTambahFilm);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "ManageFilm";
            Size = new Size(1470, 1080);
            Load += ManageFilm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFilm).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnTambahFilm;
        private Button btnEdit;
        private Button button1;
        private DataGridView dgvFilm;
    }
}
