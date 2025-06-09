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
            string username = Helpers.LoggedInUsername;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Gagal memuat profil. Username tidak ditemukan.");
                return;
            }

            RiwayatPemesananController controller = new RiwayatPemesananController();
            RiwayatPemesananModel riwayatPemesanan = controller.GetRiwayatByUsername(username);

            if (riwayatPemesanan!= null)
            {
                lblJudul.Text = riwayatPemesanan.judul;
                lblJamTayang.Text = riwayatPemesanan.jam_tayang;
            }
            else
            {
                MessageBox.Show("Data pengguna tidak ditemukan.");
            }
        }
    }
}
