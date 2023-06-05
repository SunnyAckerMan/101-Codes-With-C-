using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter time in AM/PM format (e.g., 12:30PM):");
        string inputTime = Console.ReadLine();

        // Parse the input time string
        if (DateTime.TryParse(inputTime, out DateTime time))
        {
            string militaryTime = time.ToString("HH:mm:ss");
            Console.WriteLine("Military time: " + militaryTime);
        }
        else
        {
            Console.WriteLine("Invalid input format. Please provide a valid time in AM/PM format.");
        }
    }
}
