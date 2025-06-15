using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLand.Models;

namespace MovieLand.Views
{
    public partial class CardAllRiwayat : UserControl
    {
        public CardAllRiwayat()
        {
            InitializeComponent();
        }

        private void lblNamaCustomer_Click(object sender, EventArgs e)
        {

        }

        private void CardAllRiwayat_Load(object sender, EventArgs e)
        {

        }

        public void SetData(RiwayatPemesananModel model)
        {
            lblJudul.Text = model.judul;
            lblNomorKursi.Text = $"Nomor kursi : {model.nomor_kursi}";
            lblHarga.Text = $"Rp : {model.harga:N0}";
            lblWaktu.Text = model.waktu_transaksi;
            lblNamaCustomer.Text = $"{model.nama_customer}  ({model.username})";

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
