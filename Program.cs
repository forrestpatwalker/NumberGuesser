using System;

namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            while (true)
            {
                // Set variables
                Random random = new Random();
                int correctNumber = random.Next(1, 10);
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "Please enter an actual number.");
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "WRONG! Try again.");
                    }
                    else
                    {
                        PrintColorMessage(ConsoleColor.Yellow, "CORRECT! Good job.");
                    }
                }
                
                Console.WriteLine("Play again? (Y or N)");
                string playAgain = Console.ReadLine().ToUpper();

                if (playAgain == "Y")
                {
                    continue;
                }
                else if (playAgain == "N")
                {
                    Console.WriteLine("Ok, have a nice day!");
                    break;
                }
                else
                {
                    PrintColorMessage(ConsoleColor.DarkRed, "You didnt choose Y or N so the game will end now");
                    break;
                }
            }
        }
        
        static void GetAppInfo()
        {
            // Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Forrest Walker";
            
            // App information
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Get name
            Console.WriteLine("What is your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game.", userName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}