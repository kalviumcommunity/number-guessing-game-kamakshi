using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {

                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

               
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Guess a number between 1 and 10");
                Console.ResetColor();

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
            
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                PrintColorMessage(ConsoleColor.Green, "CORRECT!! You guessed it!");

                Console.WriteLine("Play Again? [Y or N]");

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

        static void GetAppInfo()
        {
 
            string appName = "Number Guesser";
            string appAuthor = "Kamakshi pandoh";

            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("{0}: by {1}", appName, appAuthor);

            Console.ResetColor();
        }

        static void GreetUser()
        {

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }
}