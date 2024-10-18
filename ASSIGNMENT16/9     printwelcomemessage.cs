using System;

class Program
{
    
    static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void Main(string[] args)
    {
       
        Action<string> printMessage = DisplayMessage;

        
        printMessage("Welcome to Quest Global"); 
    }
}
