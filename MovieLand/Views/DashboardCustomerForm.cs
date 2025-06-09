using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieLand.Views
{
    public partial class DashboardCustomerForm : Form
    {
        public DashboardCustomerForm()
        {
            InitializeComponent();
        }


        // BUAT GANTI WARNA BUTTON AJA
        string imagePathLightBlue = Path.Combine(Application.StartupPath, "Images", "LightBlue.jpg");
        string imagePathNavy = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnDashboard.BackgroundImage = Image.FromFile(imagePathLightBlue);
            btnRiwayatPemesanan.BackgroundImage = Image.FromFile(imagePathNavy);
            btnProfile.BackgroundImage = Image.FromFile(imagePathNavy);
            btnLogout.BackgroundImage = Image.FromFile(imagePathNavy);

            //
            panelRight.Controls.Clear();
            DashboardCustomer dashboardCustomer = new DashboardCustomer();
            panelRight.Controls.Add(dashboardCustomer);
        }


        private void btnRiwayatPemesanan_Click_1(object sender, EventArgs e)
        {
            btnDashboard.BackgroundImage = Image.FromFile(imagePathNavy);
            btnRiwayatPemesanan.BackgroundImage = Image.FromFile(imagePathLightBlue);
            btnProfile.BackgroundImage = Image.FromFile(imagePathNavy);
            btnLogout.BackgroundImage = Image.FromFile(imagePathNavy);

            //
            panelRight.Controls.Clear();
            RiwayatPemesanan riwayatPemesanan = new RiwayatPemesanan();
            panelRight.Controls.Add(riwayatPemesanan);
        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {
            btnDashboard.BackgroundImage = Image.FromFile(imagePathNavy);
            btnRiwayatPemesanan.BackgroundImage = Image.FromFile(imagePathNavy);
            btnProfile.BackgroundImage = Image.FromFile(imagePathLightBlue);
            btnLogout.BackgroundImage = Image.FromFile(imagePathNavy);

            //
            panelRight.Controls.Clear();
            ProfileCustomer profileCustomer = new ProfileCustomer();
            panelRight.Controls.Add(profileCustomer);
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            btnDashboard.BackgroundImage = Image.FromFile(imagePathNavy);
            btnRiwayatPemesanan.BackgroundImage = Image.FromFile(imagePathNavy);
            btnProfile.BackgroundImage = Image.FromFile(imagePathNavy);
            btnLogout.BackgroundImage = Image.FromFile(imagePathLightBlue);


            DialogResult result = MessageBox.Show
            (
            "Yakin ingin logout?",         // Pesan
            "Konfirmasi Logout",           // Judul
            MessageBoxButtons.YesNoCancel, // Tombol: Yes / No / Cancel
            MessageBoxIcon.Question        // Icon tanda tanya
            );

            if (result == DialogResult.Yes)
            {
                Login login = new Login();
                login.Show();
                this.Hide();
            }

            else
            {
                string imagePath5 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
                btnLogout.BackgroundImage = Image.FromFile(imagePath5);
            }
        }

        private void btnRiwayatPemesanan_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void DashboardCustomerForm_Load(object sender, EventArgs e)
        {
            panelRight.Controls.Clear();
            DashboardCustomer dashboardCustomer = new DashboardCustomer();
            panelRight.Controls.Add(dashboardCustomer);
        }
    }
}
