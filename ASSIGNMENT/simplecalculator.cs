using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    internal class SimpleCalculator
    {
        public int number1;
        public int number2;


        public void DisplayResults()
        {
            int Add = number1 + number2;
            Console.WriteLine($"Sum of Numbers is :{number1 + number2}");
            int Subtact = number1 - number2;
            Console.WriteLine($"Difference  of Numbers is :{number1 - number2}");
            int Multiply = number1 * number2;
            Console.WriteLine($"Product of Numbers is :{number1 * number2}");
            int Divide = number1 / number2;
            Console.WriteLine($"Division of Numbers is :{number1 / number2}");
        }
    }

    class Program
    {


        static void Main(string[] args)
        {
            SimpleCalculator add = new SimpleCalculator();
            {
                SimpleCalculator calculator = new SimpleCalculator();
                calculator.number1 = 20;
                calculator.number2 = 10;

                calculator.DisplayResults();

                Console.ReadLine();
            }
        }
    }

}