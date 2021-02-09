using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Please enter your name...");
            string playerName = Console.ReadLine();

            Console.WriteLine($"Hello {playerName}, I want to play a game. Press enter to continue...");
            Console.ReadKey();

            Console.WriteLine("Welcome to SAW's Guessing Game! The ultimate battle of the brains and battle for your life!!");
            Console.WriteLine("Press enter to continue...");
            Console.ReadKey();

            Console.WriteLine("How to Play:\n" +
                "Players start with a score of zero.\n" +
                "If you want to live you must get a score of X.\n" +
                "Players will get 10 points for each correct answer.\n" +
                "Get three questions wrong and...\n" +
                "Billy won't be too happy. Best of Luck!\n" +
                "LET'S PLAY\n" +
                "Press enter to continue...");
            Console.ReadKey();

            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.Write("Please enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                    if (guess != secretWord)
                    {
                        Console.WriteLine("Your guess was wrong. Please press enter to try again. (Hint: it's an animal from Africa.)");
                        Console.ReadLine();
                    }
                }
                else
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.Write("You lose!");
            }
            else
            {
                Console.Write("YOU WON THE GAME");
            }

        }
    }
}
