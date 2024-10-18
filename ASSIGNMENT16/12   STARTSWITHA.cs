using System;

class Program
{
    static void Main(string[] args)
    {
        
        Predicate<string> startsWithA = str => !string.IsNullOrEmpty(str) && str.StartsWith("A", StringComparison.OrdinalIgnoreCase);

        
        string testString1 = "Quest Global";
        string testString2 = "IBM";
        string testString3 = "TCS";
        string testString4 = "WIPRO";
        string testString5 = "";

        
        Console.WriteLine($"Does \"{testString1}\" start with 'A'? " + startsWithA(testString1)); 
        Console.WriteLine($"Does \"{testString2}\" start with 'A'? " + startsWithA(testString2)); 
        Console.WriteLine($"Does \"{testString3}\" start with 'A'? " + startsWithA(testString3)); 
        Console.WriteLine($"Does \"{testString4}\" start with 'A'? " + startsWithA(testString4)); 
        Console.WriteLine($"Does an empty string start with 'A'? " + startsWithA(testString5)); 
    }
}
