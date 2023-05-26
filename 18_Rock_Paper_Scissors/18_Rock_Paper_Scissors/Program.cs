using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Rock-Paper-Scissors!");
        Console.WriteLine("Enter your move (rock, paper, or scissors):");
        string playerMove = Console.ReadLine().ToLower();

        // Generate computer's move randomly
        Random random = new Random();
        string[] validMoves = { "rock", "paper", "scissors" };
        string computerMove = validMoves[random.Next(validMoves.Length)];

        Console.WriteLine("Computer's move: " + computerMove);

        // Determine the winner
        if (playerMove == computerMove)
        {
            Console.WriteLine("It's a tie!");
        }
        else if (
            (playerMove == "rock" && computerMove == "scissors") ||
            (playerMove == "paper" && computerMove == "rock") ||
            (playerMove == "scissors" && computerMove == "paper")
        )
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Computer wins!");
        }

        Console.ReadLine();
    }
}
