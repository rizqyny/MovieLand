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
            dgvFilm.Columns["id_kategori"].HeaderText = "Kategori";
            dgvFilm.Columns["nama_kategori"].Visible = false;
        }

        private void btnTambahFilm_Click(object sender, EventArgs e)
        {
            TambahFilm tambahFilmForm = new TambahFilm();
            tambahFilmForm.ShowDialog();

            // Refresh setelah tambah
            dgvFilm.DataSource = null;
            dgvFilm.Columns.Clear(); // Hapus semua kolom sebelumnya
            dgvFilm.AutoGenerateColumns = true;
            dgvFilm.DataSource = FilmController.GetAllFilm();

        }

        private void dgvFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // (Kosongkan atau isi jika pakai tombol edit/hapus di grid)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvFilm.SelectedRows.Count > 0)
            {
                var selectedRow = dgvFilm.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id_film"].Value.ToString());

                DialogResult result = MessageBox.Show("Yakin ingin menghapus film ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var controller = new FilmController();
                    bool success = controller.DeleteFilm(id);
                    if (success)
                    {
                        MessageBox.Show("Film berhasil dihapus.");
                        dgvFilm.DataSource = FilmController.GetAllFilm();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus film.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data film yang ingin dihapus.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvFilm.SelectedRows.Count > 0)
            {
                var selectedRow = dgvFilm.SelectedRows[0];

                FilmModel selectedFilm = new FilmModel
                {
                    id_film = Convert.ToInt32(selectedRow.Cells["id_film"].Value),
                    judul = selectedRow.Cells["judul"].Value.ToString(),
                    durasi = Convert.ToInt32(selectedRow.Cells["durasi"].Value),
                    deskripsi = selectedRow.Cells["deskripsi"].Value.ToString(),
                    harga = Convert.ToInt32(selectedRow.Cells["harga"].Value),
                    gambar = selectedRow.Cells["gambar"].Value.ToString()
                };

                // Penanganan aman untuk id_kategori
                int.TryParse(selectedRow.Cells["id_kategori"].Value?.ToString(), out int idKategori);
                selectedFilm.id_kategori = idKategori;

                var editFilmForm = new EditFilm(selectedFilm);
                editFilmForm.ShowDialog();

                // Refresh
                dgvFilm.DataSource = null;
                dgvFilm.Columns.Clear();
                dgvFilm.AutoGenerateColumns = true;
                dgvFilm.DataSource = FilmController.GetAllFilm();
            }
            else
            {
                MessageBox.Show("Silakan pilih data film yang ingin diedit.");
            }
        }


    }
}
