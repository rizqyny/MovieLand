using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLand.Controllers;
using MovieLand.Models;

namespace MovieLand.Views
{
    public partial class EditFilm : Form
    {
        private FilmModel _film;

        public EditFilm(FilmModel film)
        {
            InitializeComponent();
            _film = film;

            // Isi form dengan data film
            tbJudul.Text = film.judul;
            tbDurasi.Text = film.durasi.ToString();
            tbDeskripsi.Text = film.deskripsi;
            tbHarga.Text = film.harga.ToString();
            tbGambar.Text = film.gambar;
            tbKategori.Text = film.id_kategori.ToString();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbJudul.Text) ||
                string.IsNullOrWhiteSpace(tbDurasi.Text) ||
                string.IsNullOrWhiteSpace(tbDeskripsi.Text) ||
                string.IsNullOrWhiteSpace(tbHarga.Text) ||
                string.IsNullOrWhiteSpace(tbGambar.Text) ||
                string.IsNullOrWhiteSpace(tbKategori.Text))
            {
                MessageBox.Show("Semua field harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _film.judul = tbJudul.Text;
                _film.durasi = int.Parse(tbDurasi.Text);
                _film.deskripsi = tbDeskripsi.Text;
                _film.harga = int.Parse(tbHarga.Text);
                _film.gambar = tbGambar.Text;
                _film.id_kategori = int.Parse(tbKategori.Text);  // karena kategori textbox

                var controller = new FilmController();
                bool updated = controller.UpdateFilm(_film);

                if (updated)
                {
                    MessageBox.Show("Film berhasil diperbarui!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal memperbarui film.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void EditFilm_Load(object sender, EventArgs e)
        {

        }
    }
}
