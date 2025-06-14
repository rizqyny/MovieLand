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
using MovieLand.Controllers;
using MovieLand.Models;

namespace MovieLand.Views
{
    public partial class EditCustomerMelaluiAdmin : Form
    {
        private CustomerModel customer;
        private CustomerController controller = new CustomerController();
        public EditCustomerMelaluiAdmin(CustomerModel customer)
        {
            InitializeComponent();
            this.customer = customer;
            LoadData();
        }

        private void LoadData()
        {
            txtNama.Text = customer.nama_lengkap;
            txtEmail.Text = customer.email;
            txtUsername.Text = customer.username;
            txtPassword.Text = customer.password;
            txtAlamat.Text = customer.alamat;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            customer.nama_lengkap = txtNama.Text;
            customer.email = txtEmail.Text;
            customer.username = txtUsername.Text;
            customer.password = txtPassword.Text;
            customer.alamat = txtAlamat.Text;

            controller.UpdateCustomer(customer);
            MessageBox.Show("Data berhasil diperbarui.");
            this.Close();
        }

        private void EditCustomerMelaluiAdmin_Load(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
