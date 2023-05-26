using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Generating a random integer between 1 and 100
        int randomNumber = random.Next(1, 101);
        Console.WriteLine("Random number between 1 and 100: " + randomNumber);

        // Generating a random double between 0 and 1
        double randomDouble = random.NextDouble();
        Console.WriteLine("Random double between 0 and 1: " + randomDouble);

        // Generating a random boolean
        bool randomBool = random.Next(2) == 0;
        Console.WriteLine("Random boolean: " + randomBool);

        Console.ReadLine();
    }
}
