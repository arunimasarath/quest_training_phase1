using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        
        string connectionString = "Data Source=your_server_name;Initial Catalog=your_database_name;Integrated Security=True";

      
        string query = @"
            INSERT INTO Books (BookName, Author, Price) VALUES ('The Great Gatsby', 'F. Scott Fitzgerald', 10.99);
            INSERT INTO Books (BookName, Author, Price) VALUES ('1984', 'George Orwell', 8.99);
            INSERT INTO Books (BookName, Author, Price) VALUES ('To Kill a Mockingbird', 'Harper Lee', 12.99);
            INSERT INTO Books (BookName, Author, Price) VALUES ('Moby Dick', 'Herman Melville', 15.50);
            INSERT INTO Books (BookName, Author, Price) VALUES ('War and Peace', 'Leo Tolstoy', 20.00);
        ";

       
        SqlConnection connection = new SqlConnection(connectionString);
        connection.Open();
        SqlCommand command = new SqlCommand(query, connection);
        command.ExecuteNonQuery();  // Execute the SQL query
        connection.Close();
    }
}


