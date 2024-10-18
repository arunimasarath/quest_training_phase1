using System;


delegate int Operation(int a, int b);

class Program
{
    
    static int Add(int a, int b)
    {
        return a + b;
    }

    
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static void Main(string[] args)
    {
       
        Operation op = new Operation(Add);
       
        int sum = op(10, 5);
        Console.WriteLine("Sum: " + sum); 

        
        op = Multiply;
       
        int product = op(10, 5);
        Console.WriteLine("Product: " + product);  
    }
}
