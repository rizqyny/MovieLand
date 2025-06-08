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

        private void btnSimpan_Click(object sender, EventArgs e, string username)
        {
            if (string.IsNullOrWhiteSpace(tbNama_lengkap.Text) ||
                string.IsNullOrWhiteSpace(tbAlamat.Text))
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            var context = new CustomerController();

            // Membuat objek customer dari model
            CustomerModel customer = new CustomerModel
            {
                nama_lengkap = tbNama_lengkap.Text,
                alamat = tbAlamat.Text,
            };

            bool success = context.InsertDataDiri(customer, username);
            if (success)
            {
                MessageBox.Show("Registrasi berhasil!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Registrasi gagal. Silakan coba lagi.");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            //    if (string.IsNullOrWhiteSpace(tbNama_lengkap.Text) ||
            //        string.IsNullOrWhiteSpace(tbAlamat.Text))
            //    {
            //        MessageBox.Show("Semua field harus diisi!");
            //        return;
            //    }

            //    var context = new CustomerController();

            //    // Membuat objek customer dari model
            //    CustomerModel customer = new CustomerModel
            //    {
            //        nama_lengkap = tbNama_lengkap.Text,
            //        alamat = tbAlamat.Text,
            //    };

            //    bool success = context.InsertDataDiri(customer, username);
        }
    }
}
