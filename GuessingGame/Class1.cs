using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Application
    {
        public static void Run()
        {
            string[] secretWord = { "24 miles per hour", "24mph", "24 mph",
                "twentyfourmilesperhour", "twenty-four miles per hour", "twentyfour miles per hour"};
            bool outOfGuesses = false;
            int guessCount = 0;


            Console.WriteLine("Press any key to start game...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Please enter your name...");
            string playerName = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Hello {playerName}, I want to play a game. Press enter to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Welcome to SAW's Guessing Game! The ultimate battle of the brains and battle for your life!!\n" +
                "Press ENTER to continue.....");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("How to Play:\n" +
                "You have three chances to answer the question correctly.\n" +
                "Get the question wrong three times and...\n" +
                "Billy won't be too happy. Best of Luck!\n" +
                "LET'S PLAY\n" +
                "Press enter to continue...");
            Console.ReadKey();
            Console.Clear();

            Console.Write("What is the air speed velocity of an unladen swallow?");
            string guess = Console.ReadLine();


            while (!secretWord.Contains(guess) && !outOfGuesses)
            {
                // adds +1 to guessCount 0
                guessCount++;
                Console.Clear();
                if (guessCount == 1)
                {
                    Console.WriteLine("Your guess was wrong. Please press enter to try again. (Hint: It's a European swallow.)");
                    Console.ReadLine();
                }
                if (guessCount == 2)
                {
                    Console.WriteLine("Your guess was wrong. PLease press enter to try again. (Hint: it's in miles per hour)");
                    Console.ReadKey();
                }
                if (guessCount == 3)
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lost the game!!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("YOU WIN!");
                Console.ReadKey();
            }
        }
    }
}
