using System;

class Person
{
    // Fields
    public string Name;
    public int Age;

    // Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method
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
        Person person = new Person("John", 25);

        // Access fields and call methods of the person object
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);

        person.Greet();

        Console.ReadLine();
    }
}
