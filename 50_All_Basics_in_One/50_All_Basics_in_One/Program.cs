using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
    }
}

class Program
{
    static void Main()
    {
        // Variables and data types
        string name = "Alice";
        int age = 25;
        double height = 165.5;
        bool isStudent = true;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Is Student: " + isStudent);

        // Conditional statement
        if (age >= 18)
        {
            Console.WriteLine("You are an adult.");
        }
        else
        {
            Console.WriteLine("You are a minor.");
        }

        // Loop
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Count: " + i);
        }

        // Method
        Greet();

        // Array
        int[] numbers = { 1, 2, 3, 4, 5 };
        foreach (int number in numbers)
        {
            Console.WriteLine("Number: " + number);
        }

        // Object-oriented programming
        Person person = new Person();
        person.Name = "Bob";
        person.Age = 30;
        person.DisplayInfo();

        Console.ReadLine();
    }

    static void Greet()
    {
        Console.WriteLine("Hello, World!");
    }
}
