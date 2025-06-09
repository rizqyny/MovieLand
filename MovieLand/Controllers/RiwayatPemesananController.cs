using MovieLand.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLand.Controllers
{
    class RiwayatPemesananController
    {
        public static List<RiwayatPemesananModel> GetAllRiwayat()
        {
            List<RiwayatPemesananModel> riwayats = new List<RiwayatPemesananModel>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT f.gambar, f.judul, TO_CHAR(p.jam_tayang, 'HH24:MI'), f.harga, k.nomor_kursi
                FROM transaksi t
                JOIN kursi k using(nomor_kursi)
                JOIN penayangan p using(id_penayangan)
                JOIN film f using(id_film)
                ";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RiwayatPemesananModel riwayat = new RiwayatPemesananModel
                            {
                                gambar = reader.GetString(0),
                                judul = reader.GetString(1),
                                jam_tayang = reader.GetString(2),
                                harga = reader.GetInt32(3),
                                nomor_kursi = reader.GetInt32(4)
                            };
                            riwayats.Add(riwayat);
                        }
                    }
                }
            }
            return riwayats;
        }

        public static List<RiwayatPemesananModel> GetAllRiwayat(string username)
        {
            List<RiwayatPemesananModel> riwayats = new List<RiwayatPemesananModel>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT f.gambar, f.judul, TO_CHAR(p.jam_tayang, 'HH24:MI'), f.harga, k.nomor_kursi
                FROM transaksi t
                JOIN customer c ON t.id_customer = c.id_customer
                JOIN kursi k ON t.nomor_kursi = k.nomor_kursi
                JOIN penayangan p ON t.id_penayangan = p.id_penayangan
                JOIN film f ON p.id_film = f.id_film
                WHERE c.username = @username
                ";

                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RiwayatPemesananModel riwayat = new RiwayatPemesananModel
                            {
                                gambar = reader.GetString(0),
                                judul = reader.GetString(1),
                                jam_tayang = reader.GetString(2),
                                harga = reader.GetInt32(3),
                                nomor_kursi = reader.GetInt32(4)
                            };
                            riwayats.Add(riwayat);
                        }
                    }
                }
            }
            return riwayats;
        }

        public RiwayatPemesananModel GetRiwayatByUsername(string username)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string query = @"
            SELECT f.gambar, f.judul, TO_CHAR(p.jam_tayang, 'HH24:MI'), f.harga, k.nomor_kursi
            FROM transaksi t
            JOIN customer c ON t.id_customer = c.id_customer
            JOIN kursi k ON t.nomor_kursi = k.nomor_kursi
            JOIN penayangan p ON t.id_penayangan = p.id_penayangan
            JOIN film f ON p.id_film = f.id_film
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
                    jam_tayang = reader.GetString(reader.GetOrdinal("jam_tayang")),
                    nomor_kursi = reader.GetInt32(reader.GetOrdinal("nomor_kursi")),
                    harga = reader.GetInt32(reader.GetOrdinal("harga"))                    
                };
            }
            return null;
        }
    }
}
