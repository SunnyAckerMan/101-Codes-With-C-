using System;

class HangmanGame
{
    static void Main()
    {
        Console.WriteLine("Hangman Game");

        string[] words = { "apple", "banana", "orange", "grape", "mango" };
        Random random = new Random();
        string selectedWord = words[random.Next(0, words.Length)];

        char[] guessedLetters = new char[selectedWord.Length];
        for (int i = 0; i < selectedWord.Length; i++)
        {
            guessedLetters[i] = '_';
        }

        int attempts = 6;
        bool gameOver = false;

        while (!gameOver)
        {
            Console.WriteLine("\nAttempts remaining: {0}", attempts);
            Console.WriteLine("Current word: {0}", new string(guessedLetters));

            Console.Write("Guess a letter: ");
            char guess = Console.ReadLine().ToLower()[0];

            bool correctGuess = false;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (selectedWord[i] == guess)
                {
                    guessedLetters[i] = guess;
                    correctGuess = true;
                }
            }

            if (!correctGuess)
            {
                attempts--;
                Console.WriteLine("Incorrect guess!");
                if (attempts == 0)
                {
                    gameOver = true;
                    Console.WriteLine("Game over! You lost.");
                }
            }

            if (new string(guessedLetters) == selectedWord)
            {
                gameOver = true;
                Console.WriteLine("Congratulations! You won.");
            }
        }

        Console.WriteLine("\nThe word was: {0}", selectedWord);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
