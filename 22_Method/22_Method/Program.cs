using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int sum = AddNumbers(num1, num2);

        Console.WriteLine("Sum: " + sum);

        Console.ReadLine();
    }

    static int AddNumbers(int a, int b)
    {
        int result = a + b;
        return result;
    }
}
