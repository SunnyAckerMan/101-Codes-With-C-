using System;

class Program
{
    static void Main()
    {
        int sum1 = Add(5, 10);
        int sum2 = Add(3, 7, 12);

        Console.WriteLine("Sum 1: " + sum1);
        Console.WriteLine("Sum 2: " + sum2);

        Console.ReadLine();
    }

    static int Add(int num1, int num2)
    {
        return num1 + num2;
    }

    static int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }
}
