using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {

           var data = new List<List<int>>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter Marks for Students :");
                {
                    var marks = new List<int>();
                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write($"Enter marks{j}:");
                        int mark = int.Parse(Console.ReadLine());
                        marks.Add(mark);

                    }
                    data.Add(marks);
                }
                Console.ReadKey();


                }


            }






            }
    }

