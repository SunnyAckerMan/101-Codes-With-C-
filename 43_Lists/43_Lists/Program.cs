using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of integers
        List<int> numbers = new List<int>();

        // Add elements to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Access elements in the list
        Console.WriteLine("First element: " + numbers[0]);
        Console.WriteLine("Second element: " + numbers[1]);

        // Remove an element from the list
        numbers.Remove(20);

        // Iterate over the list
        Console.WriteLine("List elements:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}
