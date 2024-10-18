//Define an abstract class called Shape with an abstract method Area().
//Create two derived classes Circle and Rectangle that implement the Area() method for calculating the area of the respective shapes.

using System;


abstract class Shape
{
    
    public abstract double Area();
}


class Circle : Shape
{
    private double radius;

    
    public Circle(double radius)
    {
        this.radius = radius;
    }

    
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}


class Rectangle : Shape
{
    private double length;
    private double width;

    
    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

   
    public override double Area()
    {
        return length * width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5);
        Console.WriteLine("Area of Circle: " + circle.Area());

       
        Shape rectangle = new Rectangle(10, 5);
        Console.WriteLine("Area of Rectangle: " + rectangle.Area());
    }
}

