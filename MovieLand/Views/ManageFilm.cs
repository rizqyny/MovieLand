using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLand.Controllers;
using MovieLand.Models;

namespace MovieLand.Views
{
    public partial class ManageFilm : UserControl
    {
        public ManageFilm()
        {
            InitializeComponent();
        }

        private void ManageFilm_Load(object sender, EventArgs e)
        {
            dgvFilm.DataSource = FilmController.GetAllFilm();

            dgvFilm.Columns["id_film"].HeaderText = "ID Film";
            dgvFilm.Columns["judul"].HeaderText = "Judul";
            dgvFilm.Columns["durasi"].HeaderText = "Durasi (menit)";
            dgvFilm.Columns["deskripsi"].HeaderText = "Deskripsi";
            dgvFilm.Columns["harga"].HeaderText = "Harga";
            dgvFilm.Columns["gambar"].HeaderText = "Path Gambar";
            dgvFilm.Columns["nama_kategori"].HeaderText = "Kategori";

            //if (!dgvFilm.Columns.Contains("Edit"))
            //{
            //    DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
            //    btnedit.Text = "Edit";
            //    btnedit.Name = "Edit";
            //    btnedit.HeaderText = "Edit";
            //    btnedit.UseColumnTextForButtonValue = true;

            //    dgvFilm.Columns.Add(btnedit);
            //}

            //if (!dgvFilm.Columns.Contains("Hapus"))
            //{
            //    DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
            //    btnedit.Text = "Hapus";
            //    btnedit.Name = "Hapus";
            //    btnedit.HeaderText = "Hapus";
            //    btnedit.UseColumnTextForButtonValue = true;

            //    dgvFilm.Columns.Add(btnedit);

        }

        private void btnTambahFilm_Click(object sender, EventArgs e)
        {
            TambahFilm tambahFilmForm = new TambahFilm();
            tambahFilmForm.ShowDialog();
        }

        private void dgvFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvFilm.SelectedRows.Count > 0)
            {
                var selectedRow = dgvFilm.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id_film"].Value);

                DialogResult result = MessageBox.Show("Yakin ingin menghapus film ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var controller = new FilmController();
                    bool success = controller.DeleteFilm(id);
                    if (success)
                    {
                        MessageBox.Show("Customer berhasil dihapus.");
                        dgvFilm.DataSource = FilmController.GetAllFilm();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus customer.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data yang ingin dihapus.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditFilm editFilmForm = new EditFilm();
            editFilmForm.ShowDialog();
        }
    }
}
