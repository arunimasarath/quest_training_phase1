using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace linq1
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Age { get; set; }
            public string Emails { get; set; }
        };
        static void Main(string[] args)
        {
            var data = new List<Person>()
            {
                new Person { Name= "Person1",Country = "US",Age= 20,Emails = },
                new Person { Name= "Person2",Country = "India",Age= 30},
                new Person { Name= "Person3",Country = "US",Age= 40}


            };
            var sortedDescending = data.OrderByDescending(x => x.Age);
            foreach (var item in sortedDescending)
            {
                Console.WriteLine(item.Name);
               
                Console.WriteLine(item.Age);
            }
            
        }
    }
}
