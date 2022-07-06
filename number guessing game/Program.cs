using System;

namespace number_guessing_game
{
    internal class Program
    {
        public static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Moamen Ashraf Muhammed";

            Console.ForegroundColor = ConsoleColor.Green;



            Console.WriteLine($"{appName}: Version ${appVersion} by {appAuthor}");

            Console.ResetColor();
        }

        public static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, Let's play a game ....");
        }

        public static void PrintColorMessage(ConsoleColor color , string message)
        {
            Console.ForegroundColor = color;



            Console.WriteLine(message);

            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            
            GetAppInfo();

           GreetUser();

            while (true)
            {
                //int correctNumber = 7;
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {

                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
             
                        // Keep going
                        continue;
                    }

                    // Cast to int and put in Guess

                    guess = int.Parse(input);

                    //Match To Correct Number 

                    if (guess != correctNumber)
                    {

                        PrintColorMessage(ConsoleColor.Red, "Wrong Number Please try again");


                    }
                }

                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT..!!");


               


                Console.WriteLine("Play Again? [Y or N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }







        }
    }
}
