using System;

class Program
{
    static void Main()
    {
        bool isSunny = true;
        bool isWarm = false;

        // Logical AND (&&) operator
        if (isSunny && isWarm)
        {
            Console.WriteLine("It's sunny and warm outside.");
        }
        else
        {
            Console.WriteLine("It's either not sunny or not warm outside.");
        }

        // Logical OR (||) operator
        if (isSunny || isWarm)
        {
            Console.WriteLine("It's either sunny or warm outside.");
        }
        else
        {
            Console.WriteLine("It's neither sunny nor warm outside.");
        }

        // Logical NOT (!) operator
        if (!isSunny)
        {
            Console.WriteLine("It's not sunny outside.");
        }
        else
        {
            Console.WriteLine("It's sunny outside.");
        }

        Console.ReadLine();
    }
}
