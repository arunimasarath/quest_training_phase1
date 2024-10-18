using System;

class Program
{
    static void Main(string[] args)
    {
        
        Predicate<int> isEven = number => number % 2 == 0;

       
        int testNumber1 = 49;
        int testNumber2 = 74;

        Console.WriteLine($"Is {testNumber1} even? " + isEven(testNumber1)); 
        Console.WriteLine($"Is {testNumber2} even? " + isEven(testNumber2)); 
    }
}
