using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List Example
        List<string> names = new List<string>();
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");

        Console.WriteLine("List Example:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        Console.WriteLine();

        // Dictionary Example
        Dictionary<string, int> ages = new Dictionary<string, int>();
        ages.Add("Alice", 25);
        ages.Add("Bob", 30);
        ages.Add("Charlie", 35);

        Console.WriteLine("Dictionary Example:");
        foreach (KeyValuePair<string, int> entry in ages)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }

        Console.WriteLine();

        // HashSet Example
        HashSet<string> countries = new HashSet<string>();
        countries.Add("USA");
        countries.Add("UK");
        countries.Add("Canada");
        countries.Add("USA"); // Adding a duplicate value (ignored)

        Console.WriteLine("HashSet Example:");
        foreach (string country in countries)
        {
            Console.WriteLine(country);
        }
    }
}
