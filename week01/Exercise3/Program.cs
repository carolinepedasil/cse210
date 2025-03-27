using System;

class Program
{
    static void Main()
    {
        Random randomGenerator = new Random();
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int attempts = 0;

            Console.WriteLine("Welcome to the Guess My Number game!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                attempts++;

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
                    Console.WriteLine($"You guessed it! It took you {attempts} tries.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}
