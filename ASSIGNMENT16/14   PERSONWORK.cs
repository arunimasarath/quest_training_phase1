using System;


abstract class Person
{
 
    public abstract void Work();
}


class Doctor : Person
{
    
    public override void Work()
    {
        Console.WriteLine("The doctor is consulting patient");
    }
}


class Engineer : Person
{
    
    public override void Work()
    {
        Console.WriteLine("The engineer creates modern era of technology");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Person myDoctor = new Doctor();
        Person myEngineer = new Engineer();

       
        myDoctor.Work(); 
        myEngineer.Work(); 
    }
}

