using System;

class Program
{
    static void Main()
    {
        // Creating and initializing an array
        int[] numbers = { 2, 4, 6, 8, 10 };

        // Iterating over array elements using foreach loop
        Console.WriteLine("Array elements:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.ReadLine();
    }
}
