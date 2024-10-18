using System;


abstract class Vehicle
{
 
    public int Speed { get; set; }

 
    public abstract void Drive();
}


class Car : Vehicle
{
  
    public Car(int speed)
    {
        Speed = speed;
    }

   
    public override void Drive()
    {
        Console.WriteLine("The car is driving at " + Speed + " km/h.");
    }
}


class Bicycle : Vehicle
{
    
    public Bicycle(int speed)
    {
        Speed = speed;
    }

   
    public override void Drive()
    {
        Console.WriteLine("The bicycle is being pedaled at " + Speed + " km/h.");
    }
}

class Program
{
    static void Main(string[] args)
    {
      
        Vehicle car = new Car(120);
        car.Drive();

        
        Vehicle bicycle = new Bicycle(15);
        bicycle.Drive();
    }
}
