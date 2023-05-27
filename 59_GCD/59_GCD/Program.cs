using System;

class Program
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int remainder = a % b;
            a = b;
            b = remainder;
        }
        return a;
    }

    static void Main()
    {
        Console.WriteLine("Enter two numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        int gcd = GCD(num1, num2);

        Console.WriteLine("GCD: " + gcd);

        Console.ReadLine();
    }
}