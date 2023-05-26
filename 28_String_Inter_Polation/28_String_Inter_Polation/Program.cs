using System;

class Program
{
    static void Main()
    {
        string name = "John";
        int age = 25;
        double height = 1.75;

        string message = $"My name is {name}, I'm {age} years old, and my height is {height} meters.";

        Console.WriteLine(message);

        Console.ReadLine();
    }
}
