using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolcollege
{
    class SchoolStudent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string SchoolName { get; set; }

        public void MethodSchool() => Console.WriteLine("From SchoolStudent");
    }
    class CollegeStudent : SchoolStudent
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string CollegeName { get; set; }

        public void MethodCollege() => Console.WriteLine("From College Student");
    }
    


    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
