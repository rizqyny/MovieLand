using MovieLand.Controllers;
using MovieLand.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieLand.Views
{
    public partial class FilmClick : Form
    {
        public FilmClick()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kursi kursi = new Kursi();
            kursi.Show();
            this.Hide();
        }

        private void FilmClick_Load(object sender, EventArgs e)
        {
            string judul = Helpers.ClickJudul;
            if (string.IsNullOrEmpty(judul))
            {
                MessageBox.Show("Gagal memuat profil. Username tidak ditemukan.");
                return;
            }

            FilmController controller = new FilmController();
            FilmModel film = controller.GetFilmbyID(judul);

            if (film != null)
            {
                lbl_Judul.Text = film.judul;
                lbl_Kategori.Text = film.nama_kategori;
                //lbl_Durasi. = film.durasi;
                //lbl_Harga.Text = film.harga;
                //lblAlamat.Text = customer.alamat;
            }
            else
            {
                MessageBox.Show("Data pengguna tidak ditemukan.");
            }
        }
    }
}
