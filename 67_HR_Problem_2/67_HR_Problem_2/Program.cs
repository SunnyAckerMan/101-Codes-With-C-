using System;

class Solution
{
    static void Main(string[] args)
    {
        string[] arrTemp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arrTemp, int.Parse);

        Array.Sort(arr);

        long minSum = 0;
        long maxSum = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            minSum += arr[i];
            maxSum += arr[arr.Length - 1 - i];
        }

        Console.WriteLine($"{minSum} {maxSum}");
    }
}
