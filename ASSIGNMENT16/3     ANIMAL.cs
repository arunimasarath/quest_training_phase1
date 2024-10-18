using System;


interface IAnimal
{
    
    void Speak();
}


class Dog : IAnimal
{
    
    public void Speak()
    {
        Console.WriteLine("The dog says: Woof!");
    }
}


class Cat : IAnimal
{
    
    public void Speak()
    {
        Console.WriteLine("The cat says: Meow!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        IAnimal dog = new Dog();
        dog.Speak();  

        
        IAnimal cat = new Cat();
        cat.Speak();  
    }
}

