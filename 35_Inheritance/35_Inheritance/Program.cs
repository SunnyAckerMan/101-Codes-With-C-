using System;

class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors { get; set; }

    public void Accelerate()
    {
        Console.WriteLine("Car is accelerating.");
    }

    public void Brake()
    {
        Console.WriteLine("Car is braking.");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Brand = "Toyota";
        myCar.Model = "Corolla";
        myCar.NumberOfDoors = 4;

        Console.WriteLine("Brand: " + myCar.Brand);
        Console.WriteLine("Model: " + myCar.Model);
        Console.WriteLine("Number of doors: " + myCar.NumberOfDoors);

        myCar.StartEngine();
        myCar.Accelerate();
        myCar.Brake();
        myCar.StopEngine();

        Console.ReadLine();
    }
}
