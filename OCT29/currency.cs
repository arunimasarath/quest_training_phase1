using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ci = new CultureInfo("en-US");
            var price = 100;
            var formattedPrice = price.ToString("C",ci);
            Console.WriteLine(formattedPrice);

        }
    }
}
