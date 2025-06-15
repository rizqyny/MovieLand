namespace MovieLand.Views
{
    partial class ManageCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomer));
            lblDataCustomer = new Label();
            dgvCustomer = new DataGridView();
            btnEdit2 = new Button();
            btnHapus2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // lblDataCustomer
            // 
            lblDataCustomer.AutoSize = true;
            lblDataCustomer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataCustomer.Location = new Point(487, 50);
            lblDataCustomer.Name = "lblDataCustomer";
            lblDataCustomer.Size = new Size(0, 81);
            lblDataCustomer.TabIndex = 2;
            // 
            // dgvCustomer
            // 
            dgvCustomer.BackgroundColor = Color.CornflowerBlue;
            dgvCustomer.BorderStyle = BorderStyle.Fixed3D;
            dgvCustomer.ColumnHeadersHeight = 40;
            dgvCustomer.Location = new Point(177, 159);
            dgvCustomer.Name = "dgvCustomer";
            dgvCustomer.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgvCustomer.Size = new Size(1043, 633);
            dgvCustomer.TabIndex = 3;
            dgvCustomer.CellContentClick += dgvCustomer_CellContentClick;
            // 
            // btnEdit2
            // 
            btnEdit2.BackColor = Color.Black;
            btnEdit2.BackgroundImage = (Image)resources.GetObject("btnEdit2.BackgroundImage");
            btnEdit2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit2.ForeColor = Color.White;
            btnEdit2.Location = new Point(703, 832);
            btnEdit2.Name = "btnEdit2";
            btnEdit2.Size = new Size(237, 61);
            btnEdit2.TabIndex = 6;
            btnEdit2.Text = "Edit";
            btnEdit2.UseVisualStyleBackColor = false;
            btnEdit2.Click += btnTambahFilm_Click;
            // 
            // btnHapus2
            // 
            btnHapus2.BackColor = Color.Black;
            btnHapus2.BackgroundImage = (Image)resources.GetObject("btnHapus2.BackgroundImage");
            btnHapus2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus2.ForeColor = Color.White;
            btnHapus2.Location = new Point(983, 832);
            btnHapus2.Name = "btnHapus2";
            btnHapus2.Size = new Size(237, 61);
            btnHapus2.TabIndex = 7;
            btnHapus2.Text = "Hapus";
            btnHapus2.UseVisualStyleBackColor = false;
            btnHapus2.Click += btnHapus2_Click;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHapus2);
            Controls.Add(btnEdit2);
            Controls.Add(dgvCustomer);
            Controls.Add(lblDataCustomer);
            Name = "ManageCustomer";
            Size = new Size(1470, 1080);
            Load += ManageCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDataCustomer;
        private DataGridView dgvCustomer;
        private Button btnEdit2;
        private Button btnHapus2;
    }
}
