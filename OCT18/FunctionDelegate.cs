using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUNCTIONDELEGATE
{
    internal class Program
    {
        static bool IsEven(int n)=>n%2==0;
        static void Main(string[] args)
        {
            Func<int,bool> a = IsEven;
            Predicate<int b = IsEven;

            var res = a(1);
            var res = b(1);

        }
    }
}
