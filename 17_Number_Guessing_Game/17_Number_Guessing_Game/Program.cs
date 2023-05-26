Random random = new Random();
bool playAgain = true;

int min = 1;
int max = 100;
int guess;
int number;
int guesses;
String response;

while (playAgain)
{
    guess = 0;
    guesses = 0;
    response = "";
    number = random.Next(min, max + 1);

    while (guess != number)
    {
        Console.WriteLine("Guess a Number between " + min + " - " + max + " : ");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Guess: " + guess);

        if (guess > number)
        {
            Console.WriteLine(guess + " is to High!");
        }
        else if (guess < number)
        {
            Console.WriteLine(guess + " is to Low!");
        }
        guesses++;
    }
    Console.WriteLine("Number: " + number);
    Console.WriteLine("You Win");
    Console.WriteLine("Guesses: " + guesses);
    Console.WriteLine("Would You Like to Play Again? (y/n)");
    response = Console.ReadLine();
    response = response.ToUpper();

    if(response == "y")
    {
        playAgain = true;
    }
    else 
    {
        playAgain = false;
    }

    Console.WriteLine();

}