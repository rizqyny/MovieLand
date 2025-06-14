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

        public RiwayatPemesananModel GetRiwayatByUsername(string username)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
            SELECT f.gambar, f.judul, f.harga, k.nomor_kursi
            FROM transaksi t
            JOIN customer c ON t.id_customer = c.id_customer
            JOIN kursi k ON t.nomor_kursi = k.nomor_kursi
            JOIN film f ON t.id_film = f.id_film
            WHERE c.username = @username
            ";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", username);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new RiwayatPemesananModel
                {
                    gambar = reader.GetString(reader.GetOrdinal("gambar")),
                    judul = reader.GetString(reader.GetOrdinal("judul")),
                    nomor_kursi = reader.GetInt32(reader.GetOrdinal("nomor_kursi")),
                    harga = reader.GetInt32(reader.GetOrdinal("harga"))                    
                };
            }
            return null;
        }
    }
}
