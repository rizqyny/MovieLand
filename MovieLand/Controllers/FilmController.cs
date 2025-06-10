using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLand.DatabasePunyaIqbal;
using MovieLand.Models;
using MovieLand.Controllers;

namespace MovieLand.Controllers
{
    public class FilmController
    {
        public static List<FilmModel> GetAllFilm()
        {
            List<FilmModel> filmModel = new List<FilmModel>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT f.id_film, f.judul, f.durasi, f.deskripsi, f.harga, f.gambar, k.nama_kategori
                FROM film f
                JOIN kategori k ON f.id_kategori = k.id_kategori
                ";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FilmModel film = new FilmModel
                            {
                                id_film = reader.GetInt32(0),
                                judul = reader.GetString(1),
                                durasi = reader.GetInt32(2),
                                deskripsi = reader.GetString(3),
                                harga = reader.GetInt32(4),
                                gambar = reader.GetString(5),
                                nama_kategori = reader.GetString(6)
                            };
                            filmModel.Add(film);
                        }
                    }
                }
                //Database.CloseConnection();
            }
            return filmModel;
        }
        public FilmModel GetFilmbyID(string judul)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = "SELECT f.judul, f.durasi, f.deskripsi, f.harga, kt.nama_kategori from film join kategori kt using(id_kategori) where judul = @judul";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@judul", judul);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new FilmModel
                {
                    id_film = reader.GetInt32(reader.GetOrdinal("id_film")),
                    judul = reader.GetString(reader.GetOrdinal("judul")),
                    durasi = reader.GetInt32(reader.GetOrdinal("durasi")),
                    deskripsi = reader.GetString(reader.GetOrdinal("deskripsi")),
                    harga = reader.GetInt32(reader.GetOrdinal("harga")),
                    gambar = reader.GetString(reader.GetOrdinal("email")),
                    nama_kategori = reader.GetString(reader.GetOrdinal("nama_kategori"))
                };
            }

            return null;

        }
    }
}
