using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "y";
        Random random = new Random();
        int magicNum = random.Next(1, 100);

        while (playAgain == "y")
        {
            int guess;
            int counter = 0;

            Console.Write("Guess the magic number! ");

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            counter += 1;

            if (guess > magicNum)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNum)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine($"You guessed the magic number in {counter} guesses!");
                Console.Write("Do you want to play again? (Y/N) ");
                playAgain = Console.ReadLine().ToLower();

                if (playAgain == "y")
                {
                    magicNum = random.Next(1, 100);
                }
            }

        }

    }
}