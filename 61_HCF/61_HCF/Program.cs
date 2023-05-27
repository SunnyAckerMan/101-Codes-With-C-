using System;

class Program
{
    static int FindHCF(int num1, int num2)
    {
        while (num2 != 0)
        {
            int remainder = num1 % num2;
            num1 = num2;
            num2 = remainder;
        }
        return num1;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter another number:");
        int anotherNumber = Convert.ToInt32(Console.ReadLine());

        int hcf = FindHCF(number, anotherNumber);

        Console.WriteLine("HCF: " + hcf);

        Console.ReadLine();
    }
}
