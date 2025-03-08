using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";
        Random randomGenerator = new Random();

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int guessCount = 0;

            Console.WriteLine("I have chosen a magic number between 1 and 100. Try to guess it!");

            // Loop until the user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} attempts.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}
