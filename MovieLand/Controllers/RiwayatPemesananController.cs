using MovieLand.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLand.Controllers
{
    public class RiwayatPemesananController
    {
        public static List<RiwayatPemesananModel> GetRiwayatByUsername(string username)
        {
            List<RiwayatPemesananModel> riwayats = new List<RiwayatPemesananModel>();

            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
            SELECT f.gambar, f.judul, f.harga, k.nomor_kursi, TO_CHAR(t.waktu, 'dd-mm-yyyy (hh24:mi)')
            FROM transaksi t
            JOIN customer c ON t.id_customer = c.id_customer
            JOIN kursi k ON t.nomor_kursi = k.nomor_kursi
            JOIN film f ON t.id_film = f.id_film
            WHERE c.username = @username
            ";

            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                var riwayat = new RiwayatPemesananModel
                {
                    gambar = reader.GetString(0),
                    judul = reader.GetString(1),
                    harga = reader.GetInt32(2),
                    nomor_kursi = reader.GetInt32(3),
                    waktu_transaksi = reader.GetString(4)
                };
                riwayats.Add(riwayat);
            }

            return riwayats;
        }

    }
}
