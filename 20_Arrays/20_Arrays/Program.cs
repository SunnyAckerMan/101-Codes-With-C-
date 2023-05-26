using System;

class Program
{
    static void Main()
    {
        // Creating and initializing an array
        int[] numbers = { 2, 4, 6, 8, 10 };

        // Accessing array elements
        Console.WriteLine("First element: " + numbers[0]);
        Console.WriteLine("Third element: " + numbers[2]);

        // Modifying array elements
        numbers[1] = 12;
        Console.WriteLine("Modified second element: " + numbers[1]);

        // Array length
        int length = numbers.Length;
        Console.WriteLine("Array length: " + length);

        // Iterating over array elements
        Console.WriteLine("Array elements:");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.ReadLine();
    }
}
