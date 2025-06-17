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

        private void LoadFilmData()
        {
            // Ambil data dulu ke variable agar tidak trigger auto-generate
            var data = FilmController.GetAllFilm();

            dgvFilm.Columns.Clear();
            
            dgvFilm.AutoGenerateColumns = false;

            // Set DataSource terakhir agar kolom tidak auto terbentuk
            dgvFilm.DataSource = data;

            // Tambahkan hanya kolom yang diinginkan
            dgvFilm.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id_film",
                HeaderText = "ID Film",
                Name = "id_film"
            });

            dgvFilm.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "judul",
                HeaderText = "Judul",
                Name = "judul"
            });

            dgvFilm.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "durasi",
                HeaderText = "Durasi (menit)",
                Name = "durasi"
            });

            dgvFilm.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "deskripsi",
                HeaderText = "Deskripsi",
                Name = "deskripsi"
            });

            dgvFilm.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "harga",
                HeaderText = "Harga",
                Name = "harga"
            });

            dgvFilm.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "gambar",
                HeaderText = "Path Gambar",
                Name = "gambar"
            });

            dgvFilm.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "nama_kategori",
                HeaderText = "Nama Kategori",
                Name = "nama_kategori"
            });


            dgvFilm.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id_kategori",
                HeaderText = "Kategori",
                Name = "id_kategori"
            });

            
        }



        private void ManageFilm_Load(object sender, EventArgs e)
        {
            LoadFilmData();
        }

        private void btnTambahFilm_Click(object sender, EventArgs e)
        {
            TambahFilm tambahFilmForm = new TambahFilm();
            tambahFilmForm.ShowDialog();

            
            //dgvFilm.DataSource = null;
            //dgvFilm.Columns.Clear();
            //dgvFilm.AutoGenerateColumns = true;
            //dgvFilm.DataSource = FilmController.GetAllFilm();
            LoadFilmData();

        }

        private void dgvFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
                        //dgvFilm.DataSource = FilmController.GetAllFilm();
                        LoadFilmData();
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

                
                int.TryParse(selectedRow.Cells["id_kategori"].Value?.ToString(), out int idKategori);
                selectedFilm.id_kategori = idKategori;

                var editFilmForm = new EditFilm(selectedFilm);
                editFilmForm.ShowDialog();

                
                //dgvFilm.DataSource = null;
                //dgvFilm.Columns.Clear();
                //dgvFilm.AutoGenerateColumns = true;
                //dgvFilm.DataSource = FilmController.GetAllFilm();
                LoadFilmData();
            }
            else
            {
                MessageBox.Show("Silakan pilih data film yang ingin diedit.");
            }
        }


    }
}
