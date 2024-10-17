using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class ClassA

    {
        public string DataA { get; set; }
        public void MethodA() => Console.WriteLine("from Class A");
    }
}
    internal class ClassB : A
{
    public string DataB { get; set; }
    public void MethodB() => Console.WriteLine("from Class B");

}
