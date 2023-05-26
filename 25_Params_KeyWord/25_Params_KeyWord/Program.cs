using System;

class Program
{
    static void Main()
    {
        int sum1 = AddNumbers(2, 4, 6);
        int sum2 = AddNumbers(3, 7, 12, 5, 8);

        Console.WriteLine("Sum 1: " + sum1);
        Console.WriteLine("Sum 2: " + sum2);

        Console.ReadLine();
    }

    static int AddNumbers(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}
