using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    abstract class CalculatorBase
    {
        public void Add(int a, int b) => Console.WriteLine(a + b);
        public void Subtract(int a, int b) => Console.WriteLine(a - b);
        public void Multiply(int a, int b) => Console.WriteLine(a * b);
        public virtual void Divide(int a, int b) => Console.WriteLine(a / b);
        public abstract void Power(int a, int b);

    }
    class Calculator : CalculatorBase
    {
        public override void Divide(int a, int b)
        {
            if(b==0)
            {
                Console.WriteLine("Divison by sero is not possible");
                return;
            }
            base.Divide(a,b);
        }
        public override void Power(int a, int b) => Console.WriteLine(Math.Pow(a,b));
        
    }
        internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
