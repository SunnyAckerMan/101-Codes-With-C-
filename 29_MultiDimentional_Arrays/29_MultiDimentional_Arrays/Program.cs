using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 3] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.WriteLine("Elements in the matrix:");

        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
