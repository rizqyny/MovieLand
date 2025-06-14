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
    public partial class ManageCustomer : UserControl
    {
        public ManageCustomer()
        {
            InitializeComponent();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = CustomerController.GetAllCustomer();

            dgvCustomer.Columns["id_customer"].HeaderText = "ID Customer";
            dgvCustomer.Columns["username"].HeaderText = "Username";
            dgvCustomer.Columns["password"].HeaderText = "Password";
            dgvCustomer.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
            dgvCustomer.Columns["alamat"].HeaderText = "Alamat";
            dgvCustomer.Columns["email"].HeaderText = "Email";

        }

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCustomer.SelectedRows[0];

                CustomerModel selectedCustomer = new CustomerModel
                {
                    id_customer = Convert.ToInt32(selectedRow.Cells["id_customer"].Value),
                    username = selectedRow.Cells["username"].Value.ToString(),
                    password = selectedRow.Cells["password"].Value.ToString(),
                    nama_lengkap = selectedRow.Cells["nama_lengkap"].Value.ToString(),
                    alamat = selectedRow.Cells["alamat"].Value.ToString(),
                    email = selectedRow.Cells["email"].Value.ToString()
                };

                var editForm = new EditCustomerMelaluiAdmin(selectedCustomer);
                editForm.ShowDialog();

                // Refresh setelah edit
                dgvCustomer.DataSource = CustomerController.GetAllCustomer();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.SelectedRows.Count > 0)
            {
                var selectedRow = dgvCustomer.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["id_customer"].Value);

                DialogResult result = MessageBox.Show("Yakin ingin menghapus customer ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var controller = new CustomerController();
                    bool success = controller.DeleteCustomer(id);
                    if (success)
                    {
                        MessageBox.Show("Customer berhasil dihapus.");
                        dgvCustomer.DataSource = CustomerController.GetAllCustomer();
                    }
                    else
                    {
                        MessageBox.Show("Gagal menghapus customer.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Silakan pilih data yang ingin dihapus.");
            }
        }
    }
}
