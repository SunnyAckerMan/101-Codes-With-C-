using System;

class Program
{
    static void Main()
    {
        double x = 2.5;
        double y = -4.3;

        // Absolute value
        double absX = Math.Abs(x);
        Console.WriteLine("Absolute value of x: " + absX);

        // Ceiling
        double ceilingY = Math.Ceiling(y);
        Console.WriteLine("Ceiling value of y: " + ceilingY);

        // Floor
        double floorX = Math.Floor(x);
        Console.WriteLine("Floor value of x: " + floorX);

        // Maximum
        double maxXY = Math.Max(x, y);
        Console.WriteLine("Maximum value between x and y: " + maxXY);

        // Minimum
        double minXY = Math.Min(x, y);
        Console.WriteLine("Minimum value between x and y: " + minXY);

        // Round
        double roundX = Math.Round(x);
        Console.WriteLine("Rounded value of x: " + roundX);

        // Square root
        double sqrtX = Math.Sqrt(x);
        Console.WriteLine("Square root of x: " + sqrtX);

        // Power
        double powerXY = Math.Pow(x, y);
        Console.WriteLine("x raised to the power of y: " + powerXY);

        // Trigonometric functions
        double sinX = Math.Sin(x);
        Console.WriteLine("Sine of x: " + sinX);

        double cosY = Math.Cos(y);
        Console.WriteLine("Cosine of y: " + cosY);

        double tanX = Math.Tan(x);
        Console.WriteLine("Tangent of x: " + tanX);

        Console.ReadLine();
    }
}
