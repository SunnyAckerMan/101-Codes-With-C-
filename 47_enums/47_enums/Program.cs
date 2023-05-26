using System;

enum DaysOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

class Program
{
    static void Main()
    {
        DaysOfWeek today = DaysOfWeek.Wednesday;

        Console.WriteLine("Today is " + today);

        if (today == DaysOfWeek.Thursday || today == DaysOfWeek.Friday)
        {
            Console.WriteLine("It's the weekend!");
        }
        else
        {
            Console.WriteLine("It's a weekday.");
        }

        Console.ReadLine();
    }
}
