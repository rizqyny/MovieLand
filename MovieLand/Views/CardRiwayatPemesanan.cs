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
using MovieLand.Views;

namespace MovieLand.Views
{
    public partial class CardRiwayatPemesanan : UserControl
    {
        public CardRiwayatPemesanan()
        {
            InitializeComponent();
        }

        private void CardRiwayatPemesanan_Load(object sender, EventArgs e)
        {

        }

        public void SetData(RiwayatPemesananModel model)
        {
            lblJudul.Text = model.judul;
            lblNomorKursi.Text = $"Nomor kursi : {model.nomor_kursi}";
            lblHarga.Text = $"Rp : {model.harga:N0}";
            lblWaktu.Text = model.waktu_transaksi;

            // Ambil gambar dari folder Images (di root project)
            string imagePath = Path.Combine(Application.StartupPath, "Images", model.gambar);
            if (File.Exists(imagePath))
            {
                pbGambarFilm.Image = Image.FromFile(imagePath);
                pbGambarFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pbGambarFilm.Image = null; // atau gambar default
            }
        }
    }
}
