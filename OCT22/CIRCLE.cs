using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIRCLE
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\connstr.mdf;Integrated Security=True;Connect Timeout=30"
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
            command.ExecuteNonQuery();
            conn.Close();


        }
    }
}

  