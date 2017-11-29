using System;
using System.Data.SQLite;

namespace SqliterDry
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var conn = new SQLiteConnection())
            {
                conn.ConnectionString = "Data Source=mydb.db;Version=3";

                var cmd = new SQLiteCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM users WHERE name LIKE @search";

                string searchString = "a";
                
                cmd.Parameters.Add(new SQLiteParameter("@search", "%" + searchString + "%"));

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
