using MovieLand.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MovieLand.Models;
using MovieLand.Views;

namespace MovieLand.Views
{
    public partial class KelolaCustomer : Form
    {
        private CustomerController controller = new CustomerController();
        public KelolaCustomer()
        {
            InitializeComponent();
            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            var customers = CustomerController.GetAllCustomer();
            dataGridView1.DataSource = customers;
        }

        private void KelolaCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedCustomer = (CustomerModel)dataGridView1.CurrentRow.DataBoundItem;
                var formEdit = new EditCustomerMelaluiAdmin(selectedCustomer);
                formEdit.ShowDialog();
                LoadCustomerData(); // Refresh setelah edit
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var selectedCustomer = (CustomerModel)dataGridView1.CurrentRow.DataBoundItem;
                var confirm = MessageBox.Show("Yakin hapus data?", "Konfirmasi", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    controller.DeleteCustomer(selectedCustomer.id_customer);
                    LoadCustomerData();
                }
            }
        }
    }
}
