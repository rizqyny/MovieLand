using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace MovieLand.DatabasePunyaIqbal
{
    public class DatabaseIqbal2
    {
        private static string localhost = "localhost";
        private static string port = "5432";
        private static string username = "postgres";
        private static string password = "vanilla22";
        private static string database = "MovieLand";

        private static NpgsqlConnection conn;

        public static NpgsqlConnection GetConnection()
        {
            if (conn == null)
            {
                string connString = $"Host={localhost};Port={port};Username={username};Password={password};Database={database}";
                conn = new NpgsqlConnection(connString);
            }
            return conn;
        }

        public static void CloseConnection()
        {
            if (conn != null)
            {
                conn.Close();
                conn = null;
            }
        }
    }
}
