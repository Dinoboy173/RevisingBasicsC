using System;

namespace _15BuildingAGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Monkey";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 6;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("You have " + (guessLimit - guessCount) + " guesses left.");
                    Console.WriteLine("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.Write("Take the L");
            }
            else
            {
                Console.Write("You won in " + guessCount + " guesses");
            }

            Console.ReadLine();
        }
    }
}
