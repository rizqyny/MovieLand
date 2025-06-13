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
        public Kursi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Kursi_Load(object sender, EventArgs e)
        {
            LoadKursiTersedia();
        }

        private void LoadKursiTersedia()
        {
            try
            {
                using (var conn = Database.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT nomor_kursi FROM kursi WHERE status = 'Tersedia' ORDER BY nomor_kursi";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int nomorKursi = reader.GetInt32(0);
                            comboBox1.Items.Add(nomorKursi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat kursi: " + ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
