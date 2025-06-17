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
                SELECT f.id_film, f.judul, f.durasi, f.deskripsi, f.harga, f.gambar, k.nama_kategori, f.id_kategori
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
                                nama_kategori = reader.GetString(6),
                                id_kategori = reader.GetInt32(7)
                            };
                            filmModel.Add(film);
                        }
                    }
                }
            }
            return filmModel;
        }
        public FilmModel GetFilmbyID(string judul)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
            SELECT f.id_film, f.judul, f.durasi, f.deskripsi, f.harga, f.gambar, kt.nama_kategori
            FROM film f
            JOIN kategori kt USING(id_kategori)
            WHERE f.judul = @judul";
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
                    gambar = reader.GetString(reader.GetOrdinal("gambar")),
                    nama_kategori = reader.GetString(reader.GetOrdinal("nama_kategori"))
                };
            }

            return null;

        }

        public bool DeleteFilm(int idFilm)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = "DELETE FROM film WHERE id_film = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", idFilm);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UpdateFilm(FilmModel film)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = @"
    UPDATE film 
    SET judul = @judul, 
        durasi = @durasi, 
        deskripsi = @deskripsi, 
        harga = @harga, 
        gambar = @gambar, 
        id_kategori = @id_kategori
    WHERE id_film = @id_film";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id_film", film.id_film);
            cmd.Parameters.AddWithValue("@judul", film.judul);
            cmd.Parameters.AddWithValue("@durasi", film.durasi);
            cmd.Parameters.AddWithValue("@deskripsi", film.deskripsi);
            cmd.Parameters.AddWithValue("@harga", film.harga);
            cmd.Parameters.AddWithValue("@gambar", film.gambar);
            cmd.Parameters.AddWithValue("@id_kategori", film.id_kategori);

            return cmd.ExecuteNonQuery() > 0;
        }
        public bool TambahFilm(FilmModel film)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string sql = @"
        INSERT INTO film (judul, durasi, deskripsi, harga, gambar, id_kategori)
        VALUES (@judul, @durasi, @deskripsi, @harga, @gambar, @id_kategori)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@judul", film.judul);
            cmd.Parameters.AddWithValue("@durasi", film.durasi);
            cmd.Parameters.AddWithValue("@deskripsi", film.deskripsi);
            cmd.Parameters.AddWithValue("@harga", film.harga);
            cmd.Parameters.AddWithValue("@gambar", film.gambar);
            cmd.Parameters.AddWithValue("@id_kategori", film.id_kategori);

            return cmd.ExecuteNonQuery() > 0;
        }
    }
}
