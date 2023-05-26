using System;

class MathUtils
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static void PrintMessage(string message)
    {
        Console.WriteLine("Message: " + message);
    }
}

class Program
{
    static void Main()
    {
        int sum = MathUtils.Add(3, 4);
        Console.WriteLine("Sum: " + sum);

        MathUtils.PrintMessage("Hello, World!");

        Console.ReadLine();
    }
}
