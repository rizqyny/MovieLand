using MovieLand.Controllers;
using MovieLand.Models;
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
    public partial class EditDataCustomer : Form
    {
        public EditDataCustomer()
        {
            InitializeComponent();
        }

        private void EditDataCustomer_Load(object sender, EventArgs e)
        {
            string username = Helpers.LoggedInUsername;
            CustomerController controller = new CustomerController();
            CustomerModel customer = controller.GetCustomerByUsername(username);

            if (customer != null)
            {
                tbNama.Text = customer.nama_lengkap;
                tbAlamat.Text = customer.alamat;
                tbEmail.Text = customer.email;
                tbPassword.Text = customer.password;
                tbUsername.Text = customer.username;
                tbUsername.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Gagal memuat data user.");
                this.Close();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {

            string username = Helpers.LoggedInUsername;

            CustomerModel updatedCustomer = new CustomerModel
            {
                nama_lengkap = tbNama.Text.Trim(),
                alamat = tbAlamat.Text.Trim(),
                email = tbEmail.Text.Trim(),
                password = tbPassword.Text.Trim(),
            };

            CustomerController controller = new CustomerController();
            bool success = controller.UpdateCustomerData(username, updatedCustomer);

            if (success)
            {
                MessageBox.Show("Data berhasil diperbarui.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Gagal memperbarui data.");
            }
        }
    }
}
