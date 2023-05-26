using System;
using System.Collections.Generic;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Create a list of Person objects
        List<Person> people = new List<Person>();

        // Create Person objects and add them to the list
        Person person1 = new Person { Name = "Alice", Age = 25 };
        people.Add(person1);

        Person person2 = new Person { Name = "Bob", Age = 30 };
        people.Add(person2);

        // Access and modify object properties
        Console.WriteLine("Name: " + people[0].Name + ", Age: " + people[0].Age);
        Console.WriteLine("Name: " + people[1].Name + ", Age: " + people[1].Age);

        people[0].Age = 26;
        people[1].Name = "Robert";

        // Iterate over the list
        Console.WriteLine("Updated list:");
        foreach (Person person in people)
        {
            Console.WriteLine("Name: " + person.Name + ", Age: " + person.Age);
        }

        Console.ReadLine();
    }
}
