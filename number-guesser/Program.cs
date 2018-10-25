using System;

// Namespace
namespace number_guesser
{
    // Main Class 
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {

            GetAppInfo(); //Run GetAppInfo function to get info

            GreetUser(); //Ask for users name and greet

            while(true) {

            //Create a new random object
            Random random = new Random();

            //Init correct number
            int correctNumber = random.Next(1, 10);

            //Init guess var
            int guess = 0;

            //Ask user a number
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while (guess != correctNumber) {
                //Get user's input
                string input = Console.ReadLine();

                //Make sure it's a number

                if(!int.TryParse(input, out guess)) {

                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                    //Keep going
                    continue;   
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                //Match guess to correct number
                if (guess != correctNumber) {
                    
                        PrintColorMessage(ConsoleColor.Red, "Wrong number please try again");

                    }
                }

                //Print success message
                PrintColorMessage(ConsoleColor.Yellow, "Correct, you WON!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y") {
                    continue;

                }
                else if (answer == "N") {
                    return;
                }

                else {
                    return;
                }

            }
        }
    
        //Get and display app info
            static void GetAppInfo () {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Patrick Towey";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser () {

            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user its not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();

        }
    }
}
