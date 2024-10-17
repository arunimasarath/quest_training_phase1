
using System;
using System.Collections.Generic;

namespace ConsoleApp7
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var ad1 = new Person();
            ad1.Name = "A";
            ad1.email = "hjt@gmail";

            
            var address = new List<Person>
            {
                new Person { Type = "home", Addresses = "ghhh" },
                new Person { Type = "home", Addresses = "rosevilla" },
                new Person { Type = "home", Addresses = "house" },
                new Person { Type = "home", Pincode = 68345 }
            };

            foreach (var person in address)
            {
                Console.WriteLine($"Type: {person.Type}, Address: {person.Addresses}, Pincode: {person.Pincode}");
            }
        }
    }
}

