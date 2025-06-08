using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLand.Models;
using Npgsql;

namespace MovieLand.Controllers
{
    class Customer
    {
        public List<Customer> DaftarCustomer = new List<Customer>();

        public bool Insert(Customer a)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            string sql = "INSERT INTO customers (username, password, email) VALUES (@username, @password, @email)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", a.username);
            cmd.Parameters.AddWithValue("@password", a.password);
            cmd.Parameters.AddWithValue("@email", a.email);
            return cmd.ExecuteNonQuery() > 0;
        }
        public bool UsernameExists(string username)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            string sql = "SELECT COUNT(*) FROM akun WHERE username = @username";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }
        public bool EmailExists(string email)
        {
            using var conn = new NpgsqlConnection(connString);
            conn.Open();
            string sql = "SELECT COUNT(*) FROM akun WHERE email = @email";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }
    }
}
