using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isEven = CheckEvenOrOdd(number);

        if (isEven)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }

        Console.ReadLine();
    }

    static bool CheckEvenOrOdd(int num)
    {
        if (num % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
