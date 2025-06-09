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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieLand.Views
{

    public partial class DataDiri : Form
    {
        public string LoggedInUsername { get; set; }
        public DataDiri()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void DataDiri_Load(object sender, EventArgs e)
        {

        }

        private void tbNama_lengkap_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAlamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Simpanasli_Click(object sender, EventArgs e)
        {
            CustomerController controller = new CustomerController();
            CustomerModel customer = new CustomerModel
            {
                nama_lengkap = tbNama_lengkap.Text,
                alamat = tbAlamat.Text
            };

            if (controller.InsertDataDiri(customer, LoggedInUsername))
            {
                MessageBox.Show("Data diri berhasil disimpan.");
                DashboardCustomer dashboard = new DashboardCustomer();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data diri.");
            }
        }
    }
}
