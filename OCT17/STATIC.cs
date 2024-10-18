using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @static
{  
    class Employee
    {
        public string Name { get; set; }
        public static string CompanyName { get; set; }

        public override string ToString()=>$"Name :{Name},Company :{CompanyName}";
        
        internal class Program
    {
        static void Main(string[] args)
        {
                Employee.CompanyName = "Old Name";
                var e1 = new Employee { Name = "E1" };
                var e2 = new Employee { Name = "E2" };

                Console.WriteLine(e1);
                Console.WriteLine(e2);
                Employee.CompanyName = "NEW NAME";
                Console.WriteLine(e1);
                Console.WriteLine(e2);

            }
    }
}
