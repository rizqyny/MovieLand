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

            // Ambil id dari tabel akun berdasarkan username
            string getIdSql = "SELECT id FROM akun WHERE username = @username";
            using var getIdCmd = new NpgsqlCommand(getIdSql, conn);
            getIdCmd.Parameters.AddWithValue("@username", username);
            var idObj = getIdCmd.ExecuteScalar();

            if (idObj == null)
            {
                return false; // username tidak ditemukan
            }

            int id_akun = Convert.ToInt32(idObj);

            // Insert data diri ke tabel customer
            string insertSql = "INSERT INTO customer (id_akun, nama_lengkap, alamat) VALUES (@id_akun, @nama_lengkap, @alamat)";
            using var insertCmd = new NpgsqlCommand(insertSql, conn);
            insertCmd.Parameters.AddWithValue("@id_akun", id_akun);
            insertCmd.Parameters.AddWithValue("@nama_lengkap", customer.nama_lengkap);
            insertCmd.Parameters.AddWithValue("@alamat", customer.alamat);

            return insertCmd.ExecuteNonQuery() > 0;
        }



        public bool UsernameExists(string username)
        {
            using var conn = Database.GetConnection();
            conn.Open();
            string sql = "SELECT COUNT(*) FROM customer WHERE username = @username";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@username", username);
            long count = (long)cmd.ExecuteScalar();
            return count > 0;
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
                Database.CloseConnection();
            }
            return customerModel;
        }
    }
}
