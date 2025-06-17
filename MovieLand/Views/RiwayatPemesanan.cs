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
            var listRiwayat = RiwayatPemesananController.GetRiwayatByUsername(Helpers.LoggedInUsername);
        }

        private void LoadDataRiwayat()
        {
            List<RiwayatPemesananModel> riwayatList = RiwayatPemesananController.GetRiwayatByUsername(Helpers.LoggedInUsername);

            int x = 212, y = 220;             // Posisi awal
            int maxPerRow = 2;              // Jumlah card per baris
            int counter = 0;

            foreach (var item in riwayatList)
            {
                CardRiwayatPemesanan card = new CardRiwayatPemesanan();
                card.SetData(item);

                card.Size = new Size(406, 108);     
                card.Location = new Point(x, y);    

                this.Controls.Add(card);              

                x += card.Width + 30;              
                counter++;

                if (counter % maxPerRow == 0)
                {
                    x = 212;                         
                    y += card.Height + 10;      
                }
            }
        }

    }
}
