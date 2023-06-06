using System;
using System.Collections.Generic;

class Program
{

    static Dictionary<char, int> CountFrequencies(string input) //Method
    {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();

        foreach (char c in input)
        {
            if (frequencies.ContainsKey(c))
            {
                frequencies[c]++;
            }
            else
            {
                frequencies[c] = 1;
            }
        }

        return frequencies;
    }

    static void Main()
    {
        string input = "cpfia74trgiusf47gw4i8!";
        Dictionary<char, int> frequencies = CountFrequencies(input);

        // Print the frequencies
        foreach (KeyValuePair<char, int> pair in frequencies)
        {
            Console.WriteLine($"Character '{pair.Key}' occurs {pair.Value} time(s).");
        }
    }


}
