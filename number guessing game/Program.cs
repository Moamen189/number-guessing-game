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

            string input = Console.ReadLine();

            Console.WriteLine($"Hello {input}, Let's play a game ....");


        }
    }
}
