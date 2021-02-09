using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;

            Console.WriteLine("Press any key to start game...");
            Console.ReadKey();

            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Please enter your guess: ");
                    guess = Console.ReadLine();
                    guessCount++;
                    if(guess != secretWord)
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
            if(outOfGuesses)
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
