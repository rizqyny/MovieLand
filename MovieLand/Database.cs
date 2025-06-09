using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace MovieLand
{
    public static class Session
    {
        public static string Username { get; set; }
        public static int IdCustomer { get; set; }
    }
    public class Database
    {
        private static string localhost = "localhost";
        private static string port = "5432";
        private static string username = "postgres";
        private static string password = "123";
        private static string database = "MovieLand";

        public static NpgsqlConnection GetConnection()
        {
            string connString = $"Host={localhost};Port={port};Username={username};Password={password};Database={database}";
            return new NpgsqlConnection(connString);
        }
    }
}

