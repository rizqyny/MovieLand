using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace MovieLand.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void LandingPage_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = tb_Username.Text.Trim();
            string password = tb_Password.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi!");
                return;
            }

            string connString = "Host=localhost;Username=postgres;Password=123;Database=MovieLand";

            using (var conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string sql = "SELECT password FROM customers WHERE username = @username";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);
                        var result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Username tidak ditemukan.");
                            return;
                        }

                        string passwordFromDb = result.ToString();

                        if (password == passwordFromDb)
                        {
                            MessageBox.Show("Login berhasil!");
                            DataDiri dashboard = new DataDiri();
                            dashboard.Show();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Password salah!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void label_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Register register = new Register();
            //register.Show();
        }
    }
}
