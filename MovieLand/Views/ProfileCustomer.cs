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


namespace MovieLand.Views
{
    public partial class ProfileCustomer : UserControl
    {
        public ProfileCustomer()
        {
            InitializeComponent();
            // Ambil username dari session
            string loggedInUsername = Session.Username;

            // Ambil data customer dari database
            CustomerController controller = new CustomerController();
            CustomerModel customer = controller.GetCustomerByUsername(loggedInUsername);

            if (customer != null)
            {
                lblNama.Text = customer.nama_lengkap;
                lblUsername.Text = customer.username;
                lblEmail.Text = customer.email;
                lblAlamat.Text = customer.alamat;
            }
            else
            {
                MessageBox.Show("Data customer tidak ditemukan.");
            }
        }

        private void ProfileCustomer_Load(object sender, EventArgs e)
        {

        }

        private void lblNama_Click(object sender, EventArgs e)
        {

        }
    }
}
