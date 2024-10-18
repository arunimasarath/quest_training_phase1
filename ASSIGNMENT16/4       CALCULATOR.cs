using System;


interface ICalculator
{
    
    int Add(int a, int b);

    
    int Subtract(int a, int b);
}

class SimpleCalculator : ICalculator
{
   
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICalculator calculator = new SimpleCalculator();

        
        int sum = calculator.Add(10, 5);
        Console.WriteLine("Sum: " + sum);  

        
        int difference = calculator.Subtract(10, 5);
        Console.WriteLine("Difference: " + difference);  
    }
}
