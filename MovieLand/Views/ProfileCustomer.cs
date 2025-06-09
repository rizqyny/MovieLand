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
using static System.Collections.Specialized.BitVector32;
using MovieLand;


namespace MovieLand.Views
{
    public partial class ProfileCustomer : UserControl
    {
        public ProfileCustomer()
        {
            InitializeComponent();
        }

        private void ProfileCustomer_Load(object sender, EventArgs e)
        {
            string username = Helpers.LoggedInUsername;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Gagal memuat profil. Username tidak ditemukan.");
                return;
            }

            CustomerController controller = new CustomerController();
            CustomerModel customer = controller.GetCustomerByUsername(username);

            if (customer != null)
            {
                lblNama.Text = customer.nama_lengkap;
                lblEmail.Text = customer.email;
                lblUsername.Text = customer.username;
                lblPassword.Text = customer.password;
                lblAlamat.Text = customer.alamat;
            }
            else
            {
                MessageBox.Show("Data pengguna tidak ditemukan.");
            }
        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void lblAlamat_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditDataCustomer editDataCustomer = new EditDataCustomer();
            editDataCustomer.Show();
        }
    }
}
