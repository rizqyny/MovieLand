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
            dgvCustomer.DataSource = Customer.GetAllFilm();

            dgvCustomer.Columns["id_customer"].HeaderText = "ID Customer";
            dgvCustomer.Columns["username"].HeaderText = "Username";
            dgvCustomer.Columns["password"].HeaderText = "Password";
            dgvCustomer.Columns["nama_lengkap"].HeaderText = "Nama Lengkap";
            dgvCustomer.Columns["alamat"].HeaderText = "Alamat";
            dgvCustomer.Columns["email"].HeaderText = "Email";

            if (!dgvCustomer.Columns.Contains("Edit"))
            {
                DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
                btnedit.Text = "Edit";
                btnedit.Name = "Edit";
                btnedit.HeaderText = "Edit";
                btnedit.UseColumnTextForButtonValue = true;

                dgvCustomer.Columns.Add(btnedit);
            }

            if (!dgvCustomer.Columns.Contains("Hapus"))
            {
                DataGridViewButtonColumn btnedit = new DataGridViewButtonColumn();
                btnedit.Text = "Hapus";
                btnedit.Name = "Hapus";
                btnedit.HeaderText = "Hapus";
                btnedit.UseColumnTextForButtonValue = true;

                dgvCustomer.Columns.Add(btnedit);
            }
        }
    }
}
