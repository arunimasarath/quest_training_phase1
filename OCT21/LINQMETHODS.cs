using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] data = { 1, 2, 3, -1, 2, 3, -9, 4, 5, 6, 7, };
            var firstItem = data.First();
            var firstOrDefault = data.FirstOrDefault();

            var lst = data.Last();
            var lastOrDefault = data.LastOrDefault();

            var SortedAscending = data.OrderBy(x=> x);
            var SortedDescending = data.OrderByDescending(x=> x);

            var min = data.Min();
            var max = data.Max();
            var minGreaterThanFive = data.Min(x => x > 5);
            var maxGreaterThanFive = data.Max(x => x > 5);

            var Count = data.Count();
            var countOfNumbersLessThanFive = data.Count(x=> x<5);

            var distinctElements = data.Distinct();

            var firstFive = data.Take(5);
            var lastFive = data.Take(5);

            var skipFirstFiveAndTakeRemaining = data.Skip(5);
            var skipLastFive = data.Skip(5);


            var takeWhile = data.TakeWhile(x=> x<5);
            var skipWhile = data.SkipWhile(x=> x<5);

            var where = data.Where(x=> x<5);
        }
    }
}
