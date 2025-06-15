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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MovieLand.Views
{
    public partial class Transaksi : Form
    {
        private int _idCustomer, _idFilm, _nomorKursi;

        public Transaksi(int idCustomer, int idFilm, int nomorKursi)
        {
            InitializeComponent();
            _idCustomer = idCustomer;
            _idFilm = idFilm;
            _nomorKursi = nomorKursi;

            // (Opsional) tampilkan informasi di label kalau ingin
            // labelInfo.Text = $"Film ID: {_idFilm}, Kursi: {_nomorKursi}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
        }

        private void btnSelesai2_Click(object sender, EventArgs e)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert ke tabel transaksi
                        string insertQuery = @"
                        INSERT INTO transaksi (waktu, id_customer, nomor_kursi, id_film)
                        VALUES (CURRENT_TIMESTAMP, @idCustomer, @nomorKursi, @idFilm)";

                        using (var cmd = new NpgsqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@idCustomer", _idCustomer);
                            cmd.Parameters.AddWithValue("@nomorKursi", _nomorKursi);
                            cmd.Parameters.AddWithValue("@idFilm", _idFilm);
                            cmd.ExecuteNonQuery();
                        }

                        // 2. Update status kursi
                        string updateQuery = @"
                        UPDATE kursi SET status = 'Tidak Tersedia'
                        WHERE nomor_kursi = @nomorKursi";

                        using (var cmd = new NpgsqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@nomorKursi", _nomorKursi);
                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                        MessageBox.Show("Transaksi berhasil disimpan!");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                    }
                }
            }
        }
    }
}
