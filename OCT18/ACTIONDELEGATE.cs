using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegate1
{
    internal class Program
    {
        static void Greet() => Console.WriteLine("Hello");
        static void GreetWithMessage(string message) => Console.WriteLine(message);
        static void Add(int a,int b) => Console.WriteLine(a + b);
        static void Main(string[] args)

        {
            Action g = Greet;
            Action <string>g2 = GreetWithMessage;
            Action<int,int> g3 = Add;

            g();
            g2("Hello");
            g3(1,2);
        }
    }
}
