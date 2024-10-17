using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getset
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        private int age;
        public int Age
        {
            get => age;
            set
            {
                if (value > 0 && value < 50)
                {
                    age = value;
                }
            }
        }
    }
}
