using System;

class Person
{
    public string Name;
    public int Age;

    // Default constructor
    public Person()
    {
        Name = "Unknown";
        Age = 0;
    }

    // Parameterized constructor with name
    public Person(string name)
    {
        Name = name;
        Age = 0;
    }

    // Parameterized constructor with name and age
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I'm " + Age + " years old.");
    }
}

class Program
{
    static void Main()
    {
        Person person1 = new Person();
        person1.Greet();  // Output: Hello, my name is Unknown and I'm 0 years old.

        Person person2 = new Person("John");
        person2.Greet();  // Output: Hello, my name is John and I'm 0 years old.

        Person person3 = new Person("Jane", 25);
        person3.Greet();  // Output: Hello, my name is Jane and I'm 25 years old.

        Console.ReadLine();
    }
}
