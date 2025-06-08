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
    public partial class DashboardAdminForm : Form
    {
        public DashboardAdminForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            // BUAT GANTI WARNA BUTTON AJA
            string imagePath = Path.Combine(Application.StartupPath, "Images", "LightBlue.jpg");
            btnDashboard.BackgroundImage = Image.FromFile(imagePath);

            string imagePath2 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnManageFilm.BackgroundImage = Image.FromFile(imagePath2);

            string imagePath3 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnManageCustomer.BackgroundImage = Image.FromFile(imagePath3);
            
            string imagePath4 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnLogout.BackgroundImage = Image.FromFile(imagePath4);

            //
            panelRight.Controls.Clear();
            DashboardAdmin dashboardAdmin = new DashboardAdmin();
            panelRight.Controls.Add(dashboardAdmin);

        }

        private void btnManageFilm_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnDashboard.BackgroundImage = Image.FromFile(imagePath);

            string imagePath2 = Path.Combine(Application.StartupPath, "Images", "LightBlue.jpg");
            btnManageFilm.BackgroundImage = Image.FromFile(imagePath2);

            string imagePath3 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnManageCustomer.BackgroundImage = Image.FromFile(imagePath3);

            string imagePath4 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnLogout.BackgroundImage = Image.FromFile(imagePath4);

            //
            panelRight.Controls.Clear();
            ManageFilm manageFilm = new ManageFilm();
            panelRight.Controls.Add(manageFilm);
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnDashboard.BackgroundImage = Image.FromFile(imagePath);

            string imagePath2 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnManageFilm.BackgroundImage = Image.FromFile(imagePath2);

            string imagePath3 = Path.Combine(Application.StartupPath, "Images", "LightBlue.jpg");
            btnManageCustomer.BackgroundImage = Image.FromFile(imagePath3);

            string imagePath4 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnLogout.BackgroundImage = Image.FromFile(imagePath4);

            //
            panelRight.Controls.Clear();
            ManageCustomer manageCustomer = new ManageCustomer();
            panelRight.Controls.Add(manageCustomer);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string imagePath = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnDashboard.BackgroundImage = Image.FromFile(imagePath);

            string imagePath2 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnManageFilm.BackgroundImage = Image.FromFile(imagePath2);

            string imagePath3 = Path.Combine(Application.StartupPath, "Images", "Navy.jpg");
            btnManageCustomer.BackgroundImage = Image.FromFile(imagePath3);

            string imagePath4 = Path.Combine(Application.StartupPath, "Images", "LightBlue.jpg");
            btnLogout.BackgroundImage = Image.FromFile(imagePath4);


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
            }
        }
    }
}
