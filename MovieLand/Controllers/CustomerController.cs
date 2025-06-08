using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLand.Models;
using Npgsql;

namespace MovieLand.Controllers
{
    public class CustomerController
    {
        public List<CustomerModel> DaftarCustomer = new List<CustomerModel>();

        public bool Insert(CustomerModel customer)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = "INSERT INTO customers (username, password, email) VALUES (@username, @password, @email)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", customer.username);
            cmd.Parameters.AddWithValue("@password", customer.password);
            cmd.Parameters.AddWithValue("@email", customer.email);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool UsernameExists(string username)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = "SELECT COUNT(*) FROM customers WHERE username = @username";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }

        public bool EmailExists(string email)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = "SELECT COUNT(*) FROM customers WHERE email = @email";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }
    }
}
