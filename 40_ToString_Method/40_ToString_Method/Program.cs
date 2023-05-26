using System;

class Program
{
    static void Main()
    {
        string str1 = "Ahmed";
        string str2 = "Sunny";

        string combinedString = ConcatenateStrings(str1, str2);
        Console.WriteLine(combinedString);

        bool areEqual = CompareStrings(str1, str2);
        Console.WriteLine("Strings are equal: " + areEqual);

        Console.ReadLine();
    }

    static string ConcatenateStrings(string str1, string str2)
    {
        return str1 + " " + str2;
    }

    static bool CompareStrings(string str1, string str2)
    {
        return str1.Equals(str2);
    }
}
