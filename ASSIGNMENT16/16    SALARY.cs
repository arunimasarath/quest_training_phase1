using System;

class Employee
{
    public double Salary { get; set; }

   
    public Employee(double salary)
    {
        Salary = salary;
    }


    public virtual double CalculateBonus()
    {
        return Salary * 0.10; 
    }
}


class Manager : Employee
{
    public Manager(double salary) : base(salary) { }


    public override double CalculateBonus()
    {
        return Salary * 0.20; 
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Employee employee = new Employee(679000);
        Console.WriteLine($"Employee's Bonus: {employee.CalculateBonus()}");

       
        Manager manager = new Manager(1200000);
        Console.WriteLine($"Manager's Bonus: {manager.CalculateBonus()}"); 
    }
}
