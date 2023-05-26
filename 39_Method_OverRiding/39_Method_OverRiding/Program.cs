using System;

class Vehicle
{
    public virtual void StartEngine()
    {
        Console.WriteLine("Generic engine starting...");
    }
}

class Car : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine starting...");
    }
}

class Motorcycle : Vehicle
{
    public override void StartEngine()
    {
        Console.WriteLine("Motorcycle engine starting...");
    }
}

class Program
{
    static void Main()
    {
        Vehicle vehicle1 = new Vehicle();
        vehicle1.StartEngine();

        Car car = new Car();
        car.StartEngine();

        Motorcycle motorcycle = new Motorcycle();
        motorcycle.StartEngine();

        Console.ReadLine();
    }
}