﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieLand.Models;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MovieLand.Controllers
{
    public class Customer
    {
        public static void Insert(CustomerModel customer)
        {
            string sql = "INSERT INTO customer(username, password, email) VALUES(@username, @password, @email)";
            try
            {
                using (var conn = Database_Iqbal.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.AddWithValue("@username", customer.username);
                        cmd.Parameters.AddWithValue("@password", customer.password);
                        cmd.Parameters.AddWithValue("@email", customer.email);
                    }
                    conn.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public static void UsernameExists(CustomerModel username)
        {
            try
            {
                using (var conn = Database_Iqbal.GetConnection())
                {
                    string sql = "SELECT COUNT(*) FROM akun WHERE username = @username";
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        long count = (long)cmd.ExecuteScalar();
                    }
                    conn.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public static void EmailExists(CustomerModel email)
        {
            try
            {
                using (var conn = Database_Iqbal.GetConnection())
                {
                    string sql = "SELECT COUNT(*) FROM akun WHERE email = @email";
                    conn.Open();
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        long count = (long)cmd.ExecuteScalar();
                    }
                    conn.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
