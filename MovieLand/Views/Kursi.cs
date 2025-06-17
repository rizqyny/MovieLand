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
    public partial class Kursi : Form
    {
        private int _idFilm;
        private int _idCustomer;

        public Kursi(int idFilm, int idCustomer)
        {
            InitializeComponent();
            _idFilm = idFilm;
            _idCustomer = idCustomer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Pilih kursi terlebih dahulu!");
                return;
            }

            int nomorKursi = Convert.ToInt32(comboBox1.SelectedItem);
            int idCustomer = Helpers.LoggedInCustomerId;
            Transaksi transaksi = new Transaksi(_idCustomer, _idFilm, nomorKursi);
            transaksi.Show();
        }

        private void Kursi_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT nomor_kursi FROM kursi WHERE status = 'Tersedia'";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader.GetInt32(0));
                    }
                }
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
