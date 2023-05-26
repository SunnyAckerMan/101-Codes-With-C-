using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Person person = new Person();

        person.Name = "Alice";
        person.Age = 25;

        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);

        Console.ReadLine();
    }
}
