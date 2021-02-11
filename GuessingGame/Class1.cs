using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GuessingGame
{ //comment
    class Application
    {
        public static void FirstWarning(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("\nI forgot to mention you're timed...opps. Better hurry buttercup!");
        }

        public static void SecondWarning(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("\nTick Tock Tick Tock slow poke...");
        }

        public static void ThirdWarning(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("\nLAST CHANCE!!");
        }

        public static void GameOver(Object source, ElapsedEventArgs e)
        {
            int loop = 0;
            while (loop == 0)
            {
                Console.WriteLine("You lost the game!!");
            }
        }

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

            // Starts question timer
            Timer gameTimer1 = new Timer(1000);
            gameTimer1.Enabled = true;
            gameTimer1.Elapsed += FirstWarning;
            gameTimer1.AutoReset = false;

            Timer gameTimer2 = new Timer(5000);
            gameTimer2.Enabled = true;
            gameTimer2.Elapsed += SecondWarning;
            gameTimer2.AutoReset = false;
            
            Timer gameTimer3 = new Timer(12000);
            gameTimer3.Enabled = true;
            gameTimer3.Elapsed += ThirdWarning;
            gameTimer3.AutoReset = false;

            Timer gameTimer4 = new Timer(15000);
            gameTimer4.Enabled = true;
            gameTimer4.Elapsed += GameOver;
            gameTimer4.AutoReset = false;

            Console.Write("What is the air speed velocity of an unladen swallow?");
            string guess = Console.ReadLine();


            while (!secretWord.Contains(guess) && !outOfGuesses)
            {
                // adds +1 to guessCount
                guessCount++;
                Console.Clear();

                if (guessCount == 1)
                {
                    Console.WriteLine("Your guess was wrong. Please enter a different guess. (Hint: It's a European swallow.)");
                    guess = Console.ReadLine();
                }
                if (guessCount == 2)
                {
                    Console.WriteLine("Your guess was wrong. Please enter a different guess. (Hint: it's in miles per hour)");
                    guess = Console.ReadLine();
                }
                if (guessCount == 3)
                {
                    outOfGuesses = true;
                }
            }
            if (outOfGuesses)
            {
                while (guessCount > 0)
                {
                    Console.WriteLine("You lost the game!!");
                }
            }
            else
            {
                Console.WriteLine("YOU WIN!");
                Console.ReadKey();
            }
        }
    }
}
