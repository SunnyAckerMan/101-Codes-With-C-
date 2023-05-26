using System;

class Program
{
    static void Main()
    {
        double sideA, sideB;
        Console.WriteLine("Enter the length of side A:");
        double.TryParse(Console.ReadLine(), out sideA);

        Console.WriteLine("Enter the length of side B:");
        double.TryParse(Console.ReadLine(), out sideB);

        double hypotenuse = CalculateHypotenuse(sideA, sideB);
        Console.WriteLine("The length of the hypotenuse is: " + hypotenuse);

        Console.ReadLine();
    }

    static double CalculateHypotenuse(double a, double b)
    {
        double hypotenuse = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        return hypotenuse;
    }
}
