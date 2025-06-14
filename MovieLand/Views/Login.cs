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
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label_Register.BackColor = Color.Transparent;
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
                if (username == "admin" && password == "admin")
                {
                    MessageBox.Show("Login sebagai admin berhasil!");
                    DashboardAdminForm adminDashboard = new DashboardAdminForm();
                    adminDashboard.Show();
                    return;
                }
                try
                {
                    conn.Open();

                    string sql = "SELECT password, nama_lengkap FROM customer WHERE username = @username";
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("username", username);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (!reader.Read())
                            {
                                MessageBox.Show("Username tidak ditemukan.");
                                return;
                            }

                            string passwordFromDb = reader.GetString(0);
                            string namaLengkap = reader.IsDBNull(1) ? "" : reader.GetString(1);
                            
                            Helpers.LoggedInUsername = username;
                            
                            if (password == passwordFromDb)
                            {
                                MessageBox.Show("Login berhasil!");

                                if (string.IsNullOrWhiteSpace(namaLengkap))
                                {
                                    
                                    DataDiri dataDiriForm = new DataDiri();
                                    dataDiriForm.LoggedInUsername = username;
                                    dataDiriForm.Show();
                                }
                                else
                                {
                                    DashboardCustomerForm dashboardForm = new DashboardCustomerForm();
                                    dashboardForm.Show();
                                }

                                //this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Password salah!");
                            }
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
            Register register = new Register();
            register.Show();
        }
    }
}
