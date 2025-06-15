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
    public partial class DashboardAdmin : UserControl
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void DashboardAdmin_Load(object sender, EventArgs e)
        {
            LoadDataRiwayat();
        }

        private void LoadDataRiwayat()
        {
            List<RiwayatPemesananModel> riwayatList = RiwayatPemesananController.GetAllRiwayat();

            int x = 120, y = 170;             // Posisi awal
            int maxPerRow = 3;              // Jumlah card per baris
            int counter = 0;

            foreach (var item in riwayatList)
            {
                CardAllRiwayat card = new CardAllRiwayat();
                card.SetData(item);

                card.Size = new Size(405, 141);       // Ukuran sesuai desain kamu
                card.Location = new Point(x, y);      // Set posisi manual

                this.Controls.Add(card);              // Tambah langsung ke UserControl

                x += card.Width + 7;                 // Geser ke kanan
                counter++;

                if (counter % maxPerRow == 0)
                {
                    x = 120;                          // Reset ke kiri
                    y += card.Height + 10;            // Turun baris
                }
            }
            //MessageBox.Show("Jumlah transaksi ditemukan: " + riwayatList.Count);
        }
    }
}
