using System;

class Program
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";

        // Concatenation using the + operator
        string fullName = firstName + " " + lastName;
        Console.WriteLine("Full Name: " + fullName);

        // String interpolation using the $ operator
        string greeting = $"Hello, {firstName} {lastName}!";
        Console.WriteLine(greeting);

        // Length property
        int fullNameLength = fullName.Length;
        Console.WriteLine("Length of Full Name: " + fullNameLength);

        // Substring method
        string substring = fullName.Substring(0, 4);
        Console.WriteLine("Substring: " + substring);

        // IndexOf method
        int indexOfSpace = fullName.IndexOf(' ');
        Console.WriteLine("Index of Space: " + indexOfSpace);

        // ToUpper and ToLower methods
        string upperCaseFullName = fullName.ToUpper();
        string lowerCaseFullName = fullName.ToLower();
        Console.WriteLine("Upper Case Full Name: " + upperCaseFullName);
        Console.WriteLine("Lower Case Full Name: " + lowerCaseFullName);

        Console.ReadLine();
    }
}
