using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace databse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\connstr.mdf;Integrated Security=True;Connect Timeout=30";
            var createTableQuery = @"CREATE TABLE BOOKS
                                    (
                                      ID INT PRIMARY KEY,
                                      name VARCHAR(50),
                                      author VARCHAR(50),
                                      price int default 0
                                    )";

            var conn = new SqlConnection(connStr);
            conn.Open();

            var command = new SqlCommand(createTableQuery, conn);
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var Id = reader.GetInt32(0);
                var Name = reader.GetString(1);
                var values = reader.GetString(2);
                var price = reader.GetString(3);

                Console.WriteLine($"{Id}- {Name}-{values}-{price}");


                //command.ExecuteNonQuery();
                conn.Close();


            }
        }
    }
}


