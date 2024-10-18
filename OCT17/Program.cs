using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    class Person
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string[] PhoneNumbers { get; set; }

        public Person(int phoneNumberCount)
        {
            CreatedAt = DateTime.Now;
            PhoneNumbers = new string[phoneNumberCount];
        }
        public Person(string name, int phoneNumberCount)
        {
            Name = name;
            CreatedAt = DateTime.Now;
            PhoneNumbers = new string[phoneNumberCount];

        }

        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
