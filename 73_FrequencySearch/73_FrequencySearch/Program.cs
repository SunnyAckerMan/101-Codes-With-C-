using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        object[] items = { 1, "apple", 2, "banana", "apple", 1, "orange", 2, "apple" };

        Dictionary<object, int> frequencyCount = new Dictionary<object, int>();

        // Count the frequency of each item
        foreach (object item in items)
        {
            if (frequencyCount.ContainsKey(item))
            {
                frequencyCount[item]++;
            }
            else
            {
                frequencyCount[item] = 1;
            }
        }

        // Display the frequencies
        foreach (var kvp in frequencyCount)
        {
            Console.WriteLine("Item: {0}, Frequency: {1}", kvp.Key, kvp.Value);
        }
    }
}