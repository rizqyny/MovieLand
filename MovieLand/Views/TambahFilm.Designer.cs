namespace MovieLand.Views
{
    partial class TambahFilm
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
            btnBatal = new Button();
            btnSimpan = new Button();
            label6 = new Label();
            textBox6 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(784, 426);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(94, 29);
            btnBatal.TabIndex = 27;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(671, 426);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 26;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 328);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 25;
            label6.Text = "Kategori:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(124, 325);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 280);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 23;
            label5.Text = "Gambar:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(124, 277);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 231);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 21;
            label4.Text = "Harga:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 147);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 20;
            label3.Text = "Deskripsi:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 100);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 19;
            label2.Text = "Durasi:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 147);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(816, 27);
            textBox3.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 50);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 16;
            label1.Text = "Judul:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 14;
            // 
            // TambahFilm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 503);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "TambahFilm";
            Text = "TambahFilm";
            Load += TambahFilm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBatal;
        private Button btnSimpan;
        private Label label6;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}