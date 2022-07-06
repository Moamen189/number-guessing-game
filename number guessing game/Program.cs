using System;

namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Moamen Ashraf Muhammed";

            Console.ForegroundColor = ConsoleColor.Green;



            Console.WriteLine($"{appName}: Version ${appVersion} by {appAuthor}");

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, Let's play a game ....");

            int correctNumber = 7;

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while(guess != correctNumber)
            {
                string input = Console.ReadLine();

                // Cast to int and put in Guess

                guess = int.Parse(input);

                //Match To Correct Number 

                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;



                    Console.WriteLine($"Wrong Number Please Try again");

                    Console.ResetColor();

                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;



            Console.WriteLine($"you are CORRECT");

            Console.ResetColor();





        }
    }
}
