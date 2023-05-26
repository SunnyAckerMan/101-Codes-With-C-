using System;

class Program
{
    static void Main()
    {
        int number = 7;

        string message = (number % 2 == 0) ? "Even" : "Odd";

        Console.WriteLine("Number is: " + message);

        Console.ReadLine();
    }
}
