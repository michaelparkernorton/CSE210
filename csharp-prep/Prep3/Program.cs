using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1 and 2
        // Console.Write("What is the magic number?: ");
        // int number = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int number;
        int guess;
        int guessCount;
        string playAgain = "yes";

        while (playAgain == "yes") {
            number = randomGenerator.Next(1, 101);
            Console.Write("What is your guess?: ");
            guess = int.Parse(Console.ReadLine());
            guessCount = 1;
            
            while (guess != number)
            {
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("Higher");
                }
                Console.Write("What is your guess?: ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;
            }
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guessCount} guesses.");
            Console.Write("Do you want to play again (yes/no) ? ");
            playAgain = Console.ReadLine();
        }

    }
}