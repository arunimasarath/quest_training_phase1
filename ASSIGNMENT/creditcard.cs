using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class CreditCard
    {
        public string CardNumber { get; set; }
        public string CardholderName { get; set; }
        public string Expiry { get; set; }
        public string Year { get; set; }
    }

    class Program
    {
        static List<CreditCard> creditCards = new List<CreditCard>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Add New Card");
                Console.WriteLine("2. Search for Card");
                Console.WriteLine("3. Update Card Number");
                Console.WriteLine("4. Delete Card");
                Console.WriteLine("5. Exit");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        AddCard();
                        break;
                    case "2":
                        SearchCard();
                        break;
                    case "3":
                        UpdateCardNumber();
                        break;
                    case "4":
                        DeleteCard();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    
        static void AddCard()
        {
            var card = new CreditCard();

            Console.WriteLine("Enter the Card Number:");
            card.CardNumber = Console.ReadLine();

            Console.WriteLine("Enter the Card Holder Name:");
            card.CardholderName = Console.ReadLine();

            Console.WriteLine("Enter the Expiry Date (MM/YY):");
            card.Expiry = Console.ReadLine();

            Console.WriteLine("Enter the Year:");
            card.Year = Console.ReadLine();

            creditCards.Add(card);
            Console.WriteLine("Card added successfully!");
        }

        static void SearchCard()
        {
            Console.WriteLine("Enter the Card Number to search:");
            var cardNumber = Console.ReadLine();

            var card = creditCards.Find(c => c.CardNumber == cardNumber);
            if (card != null)
            {
                Console.WriteLine($"Card Found: {card.CardholderName}, Expiry: {card.Expiry}, Year: {card.Year}");
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }

        static void UpdateCardNumber()
        {
            Console.WriteLine("Enter the Card Number to update:");
            var oldCardNumber = Console.ReadLine();

            var card = creditCards.Find(c => c.CardNumber == oldCardNumber);
            if (card != null)
            {
                Console.WriteLine("Enter the new Card Number:");
                card.CardNumber = Console.ReadLine();
                Console.WriteLine("Card number updated successfully!");
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }

        static void DeleteCard()
        {
            Console.WriteLine("Enter the Card Number to delete:");
            var cardNumber = Console.ReadLine();

            var card = creditCards.Find(c => c.CardNumber == cardNumber);
            if (card != null)
            {
                creditCards.Remove(card);
                Console.WriteLine("Card deleted successfully!");
            }
            else
            {
                Console.WriteLine("Card not found.");
            }
        }
    }
}




