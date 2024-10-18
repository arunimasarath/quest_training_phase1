using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getdata
{
    internal class Program
    {
        static void GetDataBasedOnTheCondition(int[] data, Predicate<int> predicate)
        {
            var result = new List<int>();
            foreach (var item in data)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            Console.WriteLine(string.Join(",", result);

            static void Main(string[] args)
            {
                var data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, -1, -2, -3 };
                GetDataBasedOnTheCondition(data, i => i % 2 == 0);
                GetDataBasedOnTheCondition(data, x => x < 0);
            }
        }
    }
}
