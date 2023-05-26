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

    // Parameterized constructor
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
        // Create an instance of Person using the default constructor
        Person person1 = new Person();
        person1.Greet();  // Output: Hello, my name is Unknown and I'm 0 years old.

        // Create an instance of Person using the parameterized constructor
        Person person2 = new Person("John", 25);
        person2.Greet();  // Output: Hello, my name is John and I'm 25 years old.

        Console.ReadLine();
    }
}
