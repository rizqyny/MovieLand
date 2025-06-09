using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLand.DatabasePunyaIqbal;
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
            string sql = "INSERT INTO customer (username, password, email) VALUES (@username, @password, @email)";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", customer.username);
            cmd.Parameters.AddWithValue("@password", customer.password);
            cmd.Parameters.AddWithValue("@email", customer.email);
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool InsertDataDiri(CustomerModel customer, string username)
        {
            using var conn = Database.GetConnection();
            conn.Open();

            string insertSql = "UPDATE customer SET nama_lengkap = @nama_lengkap, alamat = @alamat WHERE username = @username";
            using var insertCmd = new NpgsqlCommand(insertSql, conn);
            insertCmd.Parameters.AddWithValue("@nama_lengkap", customer.nama_lengkap);
            insertCmd.Parameters.AddWithValue("@alamat", customer.alamat);
            insertCmd.Parameters.AddWithValue("@username", username);

            return insertCmd.ExecuteNonQuery() > 0;
        }



        public bool UsernameExists(string username)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM customer WHERE username = @Username";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool EmailExists(string email)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = "SELECT COUNT(*) FROM customer WHERE email = @email";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@email", email);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
        }
        

        public static List<CustomerModel> GetAllCustomer()
        {
            List<CustomerModel> customerModel = new List<CustomerModel>();
            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = @"SELECT * FROM Customer";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CustomerModel customer = new CustomerModel
                            {
                                id_customer = reader.GetInt32(0),
                                username = reader.GetString(1),
                                password = reader.GetString(2),
                                nama_lengkap = reader.GetString(3),
                                alamat = reader.GetString(4),
                                email = reader.GetString(5),
                            };
                            customerModel.Add(customer);
                        }
                    }
                }
                //Database.CloseConnection();
            }
            return customerModel;
        }
    }
}
