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
        Person person1 = new Person { Name = "John", Age = 30 };
        Person person2 = new Person { Name = "Jane", Age = 25 };
        Person person3 = new Person { Name = "Mike", Age = 40 };

        Person[] people = new Person[3];
        people[0] = person1;
        people[1] = person2;
        people[2] = person3;

        foreach (Person person in people)
        {
            person.DisplayInfo();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
