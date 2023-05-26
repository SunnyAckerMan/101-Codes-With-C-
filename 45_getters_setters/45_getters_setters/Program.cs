﻿using System;

class Person
{
    private string name;
    private int age;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
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
