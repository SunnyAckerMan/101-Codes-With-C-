using System;
using System.Collections.Generic;

class CityAreaCalculator
{
    static void Main()
    {
        Console.WriteLine("City Area Calculator");

        // Dictionary to store city areas in square miles
        Dictionary<string, double> cityAreas = new Dictionary<string, double>();

        // Add city areas to the dictionary
        cityAreas.Add("New York", 302.6);
        cityAreas.Add("Los Angeles", 468.7);
        cityAreas.Add("Chicago", 227.3);
        cityAreas.Add("Houston", 637.5);
        cityAreas.Add("Phoenix", 517.6);

        Console.WriteLine("City\t\tSquare Area (in square miles)");
        Console.WriteLine("=====================================");

        // Calculate and display the square area for each city
        foreach (KeyValuePair<string, double> cityArea in cityAreas)
        {
            double squareArea = Math.Sqrt(cityArea.Value);
            Console.WriteLine($"{cityArea.Key}\t\t{squareArea:F2}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
