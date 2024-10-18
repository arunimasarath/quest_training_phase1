using System;

class Program
{
    static void Main(string[] args)
    {
        
        Func<string, int> GetStringLength = str => str.Length;

        
        string exampleString = "Quest Global";
        int length = GetStringLength(exampleString);

        
        Console.WriteLine("The length of the string is: " + length);  
    }
}
