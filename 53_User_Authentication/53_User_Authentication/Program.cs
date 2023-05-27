using System;

class Program
{
    static void Main()
    {
        // Simulated user credentials for authentication
        string username = "admin";
        string password = "@admin99";

        Console.WriteLine("Enter username:");
        string inputUsername = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string inputPassword = Console.ReadLine();

        if (inputUsername == username && inputPassword == password)
        {
            Console.WriteLine("Authentication successful! Welcome, " + username + ".");
        }
        else
        {
            Console.WriteLine("Authentication failed. Invalid username or password.");
        }

        Console.ReadLine();
    }
}
