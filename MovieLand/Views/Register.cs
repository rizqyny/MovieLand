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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Register_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_Username.Text) ||
                string.IsNullOrWhiteSpace(tb_Password.Text) ||
                string.IsNullOrWhiteSpace(tb_Email.Text) ||
                string.IsNullOrWhiteSpace(tb_PasswordConfirm.Text))
            {
                MessageBox.Show("Semua field harus diisi!");
                return;
            }

            if (tb_Password.Text != tb_PasswordConfirm.Text)
            {
                MessageBox.Show("Password tidak cocok!");
                return;
            }

            var context = new CustomerController();

            if (context.UsernameExists(tb_Username.Text))
            {
                MessageBox.Show("Username sudah tidak tersedia!");
                return;
            }

            if (context.EmailExists(tb_Email.Text))
            {
                MessageBox.Show("Email sudah digunakan!");
                return;
            }

            CustomerModel customer = new CustomerModel
            {
                username = tb_Username.Text,
                password = tb_Password.Text,
                email = tb_Email.Text
            };

            bool success = context.Insert(customer);
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

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
