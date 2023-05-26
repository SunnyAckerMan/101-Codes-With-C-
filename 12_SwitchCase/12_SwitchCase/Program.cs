using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a day number (1-7):");
        int dayNumber = Convert.ToInt32(Console.ReadLine());

        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "Saturday";
                break;
            case 2:
                dayName = "Sunday";
                break;
            case 3:
                dayName = "Monday";
                break;
            case 4:
                dayName = "Tuesday";
                break;
            case 5:
                dayName = "Wednesday";
                break;
            case 6:
                dayName = "Thursday";
                break;
            case 7:
                dayName = "Friday";
                break;
            default:
                dayName = "Invalid day";
                break;
        }

        Console.WriteLine("The day is: " + dayName);

        Console.ReadLine();
    }
}
