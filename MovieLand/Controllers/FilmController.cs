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
            using (var conn = DatabaseIqbal2.GetConnection())
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
                DatabaseIqbal2.CloseConnection();
            }
            return filmModel;
        }
    }
}
