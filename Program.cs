using System;
using Microsoft.Data.Sqlite;

namespace DotnetSqliter
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var conn = new SqliteConnection())
            {
                conn.ConnectionString = "Data Source=mydb.sqlite3";

                var cmd = new SqliteCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM users WHERE name LIKE @search";

                string searchString = "a";
                
                cmd.Parameters.Add(new SqliteParameter("@search", "%" + searchString + "%"));

                conn.Open();

                var rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine("{0} {1}", rdr[0], rdr[1]);
                }
            }
        }
    }
}
