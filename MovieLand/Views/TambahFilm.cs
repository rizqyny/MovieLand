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
    public partial class TambahFilm : Form
    {
        public TambahFilm()
        {
            InitializeComponent();
        }

        private void TambahFilm_Load(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                // Ambil data dari input TextBox
                string judul = tbJudul.Text;
                int durasi = int.Parse(tbDurasi.Text);
                string deskripsi = tbDeskripsi.Text;
                int harga = int.Parse(tbHarga.Text);
                string gambar = tbGambar.Text;
                int id_kategori = int.Parse(tbKategori.Text);

                // Buat objek FilmModel
                FilmModel film = new FilmModel
                {
                    judul = judul,
                    durasi = durasi,
                    deskripsi = deskripsi,
                    harga = harga,
                    gambar = gambar,
                    id_kategori = id_kategori
                };

                // Simpan ke database
                var controller = new FilmController();
                bool success = controller.TambahFilm(film);

                if (success)
                {
                    MessageBox.Show("Film berhasil ditambahkan.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal menambahkan film.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Pastikan semua input berupa angka untuk durasi, harga, dan ID kategori.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

    }
}
