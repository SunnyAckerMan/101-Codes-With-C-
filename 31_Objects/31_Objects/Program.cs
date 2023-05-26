using System;

class Person
{
    public string Name;
    public int Age;

    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I'm " + Age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person();

        // Set the values of the object's properties
        person.Name = "John";
        person.Age = 25;

        // Call the object's method
        person.Greet();

        Console.ReadLine();
    }
}
