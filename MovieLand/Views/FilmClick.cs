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
        private readonly FilmModel _film;

        public FilmClick(FilmModel film)
        {
            InitializeComponent();
            _film = film;
        }

        private void FilmClick_Load(object sender, EventArgs e)
        {
            lbl_Judul.Text = _film.judul;
            lbl_Durasi.Text = _film.durasi + " menit";
            //lbl_Deskripsi.Text = _film.deskripsi;
            lbl_Harga.Text = "Rp " + _film.harga.ToString("N0");
            lbl_Kategori.Text = _film.nama_kategori;

            string path = Path.Combine(Application.StartupPath, "Images", _film.gambar);
            if (File.Exists(path))
            {
                pb_Poster.Image = Image.FromFile(path);
            }
        }


        private void btn_Pesan_Click(object sender, EventArgs e)
        {
            int idCustomer = 1; // Gantilah dengan data user yang sedang login
            Kursi kursiForm = new Kursi(_film.id_film, idCustomer);
            kursiForm.Show();
            //this.Close(); Tutup form film jika perlu
        }

        private void btn_Tutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
