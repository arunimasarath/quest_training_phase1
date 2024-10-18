using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public int Pages { get; set; }

    }
    public Book(string title, string author, decimal price,int pages)
    {
        return $"Title :{title},Author :{author},Price {price},Pages :{pages}";

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IBookManager bookManager = new BookManager();
            string filePath = "books.txt";

            
            bookManager.LoadBooksFromFile(filePath);

            while (true)
            {
                Console.WriteLine("\nBook Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. View Books");
                Console.WriteLine("3. Save Books to File");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                       
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter Book Author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter Book Price: ");
                        decimal price = decimal.Parse(Console.ReadLine());
                        Console.Write("Enter Number of Pages: ");
                        int pages = int.Parse(Console.ReadLine());
                        Book book = new Book(title, author, price, pages);
                        bookManager.AddBook(book);
                        break;

                    case "2":
                      
                        bookManager.ViewBooks();
                        break;

                    case "3":
                        
                        bookManager.SaveBooksToFile(filePath);
                        break;

                    case "4":
                        
                        return;

                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }
    }
}
