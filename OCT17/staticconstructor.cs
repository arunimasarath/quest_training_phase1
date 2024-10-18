using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static2
{
    class Employee
    {
        public string Name { get; set; }
        public static string CompanyName { get; set; }

        static Employee()
        {
            CompanyName = "Microsoft";
        }
        public Employee(string name) => Name = name;

        public override string ToString() => Name + " " + CompanyName;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("company name :" +Employee.CompanyName);
            var e1 = new Employee("Joe");
            Console.WriteLine(e1);
        }
    }
}
