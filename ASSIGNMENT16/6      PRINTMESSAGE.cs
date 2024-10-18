using System;


delegate void PrintMessage(string message);

class Program
{
   
    static void DisplayMessage(string message)
    {
        Console.WriteLine(message);
    }

    static void Main(string[] args)
    {
        
        PrintMessage printMsg = new PrintMessage(DisplayMessage);

        printMsg("Hello, this is a message printed using a delegate!");

    }
}
