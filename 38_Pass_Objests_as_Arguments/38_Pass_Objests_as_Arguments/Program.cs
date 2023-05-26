using System;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void UpdateAge(int newAge)
    {
        Age = newAge;
    }

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
        Person person = new Person { Name = "John", Age = 30 };

        Console.WriteLine("Before Update:");
        person.DisplayInfo();

        UpdatePersonAge(person, 35);

        Console.WriteLine("After Update:");
        person.DisplayInfo();

        Console.ReadLine();
    }

    static void UpdatePersonAge(Person p, int newAge)
    {
        p.UpdateAge(newAge);
    }
}
