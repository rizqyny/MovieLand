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
    public partial class RiwayatPemesanan : UserControl
    {
        public RiwayatPemesanan()
        {
            InitializeComponent();
        }

        private void RiwayatPemesanan_Load(object sender, EventArgs e)
        {
            LoadDataRiwayat();
        }

        private void LoadDataRiwayat()
        {
            List<RiwayatPemesananModel> riwayatList = RiwayatPemesananController.GetRiwayatByUsername(Helpers.LoggedInUsername);

            int x = 200, y = 220;             // Posisi awal
            int maxPerRow = 2;              // Jumlah card per baris
            int counter = 0;

            foreach (var item in riwayatList)
            {
                CardRiwayatPemesanan card = new CardRiwayatPemesanan();
                card.SetData(item);

                card.Size = new Size(406, 108);       // Ukuran sesuai desain kamu
                card.Location = new Point(x, y);      // Set posisi manual

                this.Controls.Add(card);              // Tambah langsung ke UserControl

                x += card.Width + 30;                 // Geser ke kanan
                counter++;

                if (counter % maxPerRow == 0)
                {
                    x = 200;                          // Reset ke kiri
                    y += card.Height + 10;            // Turun baris
                }
            }
        }

    }
}
