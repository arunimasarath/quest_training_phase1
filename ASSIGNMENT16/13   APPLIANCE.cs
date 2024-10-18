using System;


abstract class Appliance
{
   
    public abstract void TurnOn();
}


class Fan : Appliance
{
   
    public override void TurnOn()
    {
        Console.WriteLine("The fan is now turned on.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Appliance Fan = new Fan();

       
        Fan.TurnOn();
    }
}
