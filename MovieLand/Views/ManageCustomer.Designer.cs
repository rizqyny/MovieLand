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
            lblDataCustomer = new Label();
            dgvCustomer = new DataGridView();
            btnEdit = new Button();
            btnHapus = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCustomer).BeginInit();
            SuspendLayout();
            // 
            // lblDataCustomer
            // 
            lblDataCustomer.AutoSize = true;
            lblDataCustomer.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDataCustomer.Location = new Point(487, 50);
            lblDataCustomer.Name = "lblDataCustomer";
            lblDataCustomer.Size = new Size(453, 81);
            lblDataCustomer.TabIndex = 2;
            lblDataCustomer.Text = "Data Customer";
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
            // btnEdit
            // 
            btnEdit.Location = new Point(846, 832);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnHapus
            // 
            btnHapus.Location = new Point(1126, 832);
            btnHapus.Name = "btnHapus";
            btnHapus.Size = new Size(94, 29);
            btnHapus.TabIndex = 5;
            btnHapus.Text = "Hapus";
            btnHapus.UseVisualStyleBackColor = true;
            btnHapus.Click += btnHapus_Click;
            // 
            // ManageCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnHapus);
            Controls.Add(btnEdit);
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
        private Button btnEdit;
        private Button btnHapus;
    }
}
