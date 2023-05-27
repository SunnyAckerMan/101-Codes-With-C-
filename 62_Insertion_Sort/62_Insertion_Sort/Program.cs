using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }

            arr[j + 1] = key;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the number of elements in the array:");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];

        Console.WriteLine("Enter the elements:");

        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array before sorting:");
        PrintArray(arr);

        InsertionSort(arr);

        Console.WriteLine("Array after sorting:");
        PrintArray(arr);

        Console.ReadLine();
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
