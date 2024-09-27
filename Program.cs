namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;             // Saves the user input for the switch menu.
            int guess;                  // User guess.
            int guesses = 0;            // Counts the amount of guesses.
            int guessLeft = 5;          // Guesses left.
            bool gameEngine = true;     // Boolean value if the user wants to exit the program.

            RiddleMeThis();
            RiddleMeThis();
            RiddleMeThis();           

            Console.WriteLine("\n---------------------------------\n" +
                "--Welcome to the guessing game!--\n" +
                "---------------------------------");
            do
            {
                MenuDisplay();    // Displays the menu for the user.
                while (!int.TryParse(Console.ReadLine(), out menuChoice)) //TryParse so the program can handle improper inputs.
                {                                                       //While loop makes sure the program doesn't move on until correct input.
                    Console.Clear();
                    Console.WriteLine("Incorrect input, try again.");
                    Thread.Sleep(2500);
                    Console.Clear();
                    MenuDisplay();
                    Console.Write("Write a number: ");
                }
                gameEngine = false;
            } while (gameEngine == true);

            switch (menuChoice)  // Switch meny that select case based on the users input.
            {
                case 1:
                    bool playAgain1 = true;
                    do
                    {
                        Console.Clear();
                        Random RandomNumber = new Random();
                        int rng = RandomNumber.Next(1, 26);  // Creates a random integer between a specific value.
                        Console.WriteLine("Guess on a number between 1 - 25, you have 5 tries to do it.");
                        while (!int.TryParse(Console.ReadLine(), out guess))  // Handles incorrect inputs.
                        {
                            Console.Write("Incorrect input, write a number:");
                        }
                        guesses = 1;  // Start value of the number of guesses.
                        guessLeft = 4;  // Start value of the number of guesses left.
                        bool game1 = true;  // Boolean to keep the while loop below alive until false.

                        while (game1 == true)
                        {
                            if (guess > rng && guesses != 5) // Condition if the guess it too high.
                            {
                                Console.WriteLine($"The number is too high, you have {guessLeft} guesses left.");
                                while (!int.TryParse(Console.ReadLine(), out guess))
                                {
                                    Console.Write("Incorrect input, write a number:");
                                }
                            }
                            else if (guess < rng && guesses != 5) // Condition if the guess is too low.
                            {
                                Console.WriteLine($"The number is too low, you have {guessLeft} guesses left.");
                                while (!int.TryParse(Console.ReadLine(), out guess))
                                {
                                    Console.Write("Incorrect input, write a number:");
                                }
                            }
                            else if (guess != rng && guesses == 5) // Condition that makes the game stop if the guess is incorrect and you wasted your guesses.
                            {
                                
                                Console.WriteLine($"\nClose but no cigar! The number i was searching for was {rng}.\n\n" +
                                $"Do you want to try again? Y/N");
                                string playAgain = Console.ReadLine();
                                if (playAgain.ToUpper() == "Y")
                                {
                                    playAgain1 = true;
                                    game1 = false;
                                    guess = 0;          // Different integers and boolean values that resets for the next game.
                                    guesses = 0;
                                    guessLeft = 0;
                                }
                                else
                                {
                                    playAgain1 = false;
                                    break;
                                }
                            }
                            else if (guess == rng)
                            {
                                Console.WriteLine($"Congratulations, you made it! It only took you {guesses} {(guesses == 1 ? "guess" : "guesses")}.");
                                Console.WriteLine("\nDo you want to try again? (Y/N) ");
                                string playAgain = Console.ReadLine();
                                if (playAgain.ToUpper() == "Y")      // ToUpper to handle lowercase inputs.
                                {
                                    playAgain1 = true;
                                    game1 = false;
                                    guess = 0;          // Different integers and boolean values that resets for the next game.
                                    guesses = 0;
                                    guessLeft = 0;
                                }
                                else
                                {
                                    playAgain1 = false;
                                    break;
                                }
                            }
                            guesses++;   // Adds to the guesses variable.
                            guessLeft--; // Subtracts from the guesses that are left.
                        }
                    } while (playAgain1 == true);
                    break;
                case 2:
                    bool playAgain2 = true;
                    do
                    {
                        Console.Clear();
                        Random RandomNumber = new Random();
                        int rng = RandomNumber.Next(1, 51);
                        Console.WriteLine("Guess on a number between 1 - 50, you have 5 tries to do it.");
                        while (!int.TryParse(Console.ReadLine(), out guess))
                        {
                            Console.Write("Incorrect input, write a number:");
                        }
                        guesses = 1;
                        guessLeft = 4;
                        bool game2 = true;

                        while (game2 == true)
                        {
                            if (guess > rng && guesses != 5)
                            {
                                Console.WriteLine($"The number is too high, you have {guessLeft} guesses left.");
                                while (!int.TryParse(Console.ReadLine(), out guess))
                                {
                                    Console.Write("Incorrect input, write a number:");
                                }
                            }
                            else if (guess < rng && guesses != 5)
                            {
                                Console.WriteLine($"The number is too low, you have {guessLeft} guesses left.");
                                while (!int.TryParse(Console.ReadLine(), out guess))
                                {
                                    Console.Write("Incorrect input, write a number:");
                                }
                            }
                            else if (guess != rng && guesses == 5)
                            {
                                Console.WriteLine($"\nClose but no cigar! The number i was searching for was {rng}.\n\n" +
                                $"Do you want to try again? Y/N");
                                string playAgain = Console.ReadLine();
                                if (playAgain.ToUpper() == "Y")
                                {
                                    playAgain2 = true;
                                    game2 = false;
                                    guess = 0;
                                    guesses = 0;
                                    guessLeft = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Thanks for playing my number guessing game.");
                                    Console.ReadKey();
                                    playAgain2 = false;
                                    break;
                                }
                            }
                            else if (guess == rng)
                            {
                                Console.WriteLine($"Congratulations, you made it! It only took you {guesses} {(guesses == 1 ? "guess" : "guesses")}.");
                                Console.WriteLine("\nDo you want to try again? (Y/N) ");
                                string playAgain = Console.ReadLine();
                                if (playAgain.ToUpper() == "Y")
                                {
                                    playAgain2 = true;
                                    game2 = false;
                                    guess = 0;
                                    guesses = 0;
                                    guessLeft = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Thanks for playing my number guessing game.");
                                    Console.ReadKey();
                                    playAgain2 = false;
                                    break;
                                }
                            }
                            guesses++;
                            guessLeft--;
                        }
                    } while (playAgain2 == true);
                    break;

                case 3:
                    bool playAgain3 = true;
                    Console.Clear();
                    do
                    {
                        int firstNum = 0;           // Integer for when the user wish to decide numbers.
                        int secondNum = 0;          // Integer for when the user wish to decide numbers.
                        bool game3 = true;
                        bool testNum = true;        // Bool to run if statement to check if the user did valid inputs.


                        Console.Write("Write your first number: ");
                        while (!int.TryParse(Console.ReadLine(), out firstNum))
                        {
                            Console.Write("Incorrect input, write a number: ");
                        }
                        Console.Write("Write your second number: ");
                        while (!int.TryParse(Console.ReadLine(), out secondNum))
                        {
                            Console.Write("Incorrect input, write a number: ");
                        }

                        while (testNum == true)
                        {
                            if (firstNum == secondNum)
                            {
                                Console.WriteLine("You can't pick the same numbers silly.");
                                Thread.Sleep(2500);
                                Console.Clear();
                                Console.Write("Write your first number: ");
                                while (!int.TryParse(Console.ReadLine(), out firstNum))
                                {
                                    Console.Write("Incorrect input, write a number: ");
                                }
                                Console.Write("Write your second number: ");
                                while (!int.TryParse(Console.ReadLine(), out firstNum))
                                {
                                    Console.Write("Incorrect input, write a number: ");
                                }
                            }
                            else if (firstNum - secondNum == 1 || secondNum - firstNum == 1)
                            {
                                Console.WriteLine("You seem inventive.\n" +
                                    "Broaden your imagination.");
                                Thread.Sleep(2500);
                                Console.Clear();
                                Console.Write("Write your first number: ");
                                while (!int.TryParse(Console.ReadLine(), out firstNum))
                                {
                                    Console.Write("Incorrect input, write a number: ");
                                }
                                Console.Write("Write your second number: ");
                                while (!int.TryParse(Console.ReadLine(), out secondNum))
                                {
                                    Console.Write("Incorrect input, write a number: ");
                                }
                            }
                            else if (firstNum > secondNum)
                            {
                                Console.WriteLine("Please make sure, that your first number is lesser than your second.");
                                Thread.Sleep(2500);
                                Console.Clear();
                                Console.Write("Write your first number: ");
                                while (!int.TryParse(Console.ReadLine(), out firstNum))
                                {
                                    Console.Write("Incorrect input, write a number: ");
                                }
                                Console.Write("Write your second number: ");
                                while (!int.TryParse(Console.ReadLine(), out secondNum))
                                {
                                    Console.Write("Incorrect input, write a number: ");
                                }
                            }
                            else
                            {
                                testNum = false;
                            }
                        }
                        int random = UserGame(firstNum, secondNum);
                        Console.WriteLine($"Guess on a number between {firstNum} - {secondNum}, you have 5 tries to do it.");
                        while (!int.TryParse(Console.ReadLine(), out guess))
                        {
                            Console.Write("Incorrect input, write a number:");
                        }
                        guesses = 1;
                        guessLeft = 4;
                        while (game3 == true)
                        {
                            if (guess > random && guesses != 5)
                            {
                                Console.WriteLine($"The number is too high, you have {guessLeft} guesses left.");
                                while (!int.TryParse(Console.ReadLine(), out guess))
                                {
                                    Console.Write("Incorrect input, write a number:");
                                }
                            }
                            else if (guess < random && guesses != 5)
                            {
                                Console.WriteLine($"The number is too low, you have {guessLeft} guesses left.");
                                while (!int.TryParse(Console.ReadLine(), out guess))
                                {
                                    Console.Write("Incorrect input, write a number:");
                                }
                            }
                            else if (guess != random && guesses == 5)
                            {
                                Console.WriteLine($"\nClose but no cigar! The number i was searching for was {random}.\n\n" +
                                $"Do you want to try again? Y/N");
                                string playAgain = Console.ReadLine();
                                if (playAgain.ToUpper() == "Y")
                                {
                                    Console.Clear();
                                    playAgain3 = true;
                                    game3 = false;
                                    guess = 0;
                                    guesses = 0;
                                    guessLeft = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Thanks for playing my number guessing game.");
                                    Console.ReadKey();
                                    playAgain3 = false;
                                    break;
                                }
                            }
                            else if (guess == random)
                            {
                                Console.WriteLine($"Congratulations, you made it! It only took you {guesses} {(guesses == 1 ? "guess" : "guesses")}.");
                                Console.WriteLine("\nDo you want to try again? (Y/N) ");
                                string playAgain = Console.ReadLine();
                                if (playAgain.ToUpper() == "Y")
                                {
                                    Console.Clear();
                                    playAgain3 = true;
                                    game3 = false;
                                    guess = 0;          
                                    guesses = 0;
                                    guessLeft = 0;
                                }
                                else
                                {
                                    Console.WriteLine("Thanks for playing my number guessing game.");
                                    Console.ReadKey();
                                    playAgain3 = false;
                                    break;
                                }
                            }
                            guesses++;
                            guessLeft--;
                        }

                    } while (playAgain3 == true);
                    break;

                case 4:
                    Console.WriteLine("Thanks for playing my number guessing game.");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("Please make a correct input.");
                    break;
            }           
        }
        private static void MenuDisplay()    // Not my smartest method, the menu is kind off nice to see among the code. Still learning.
        {
            Console.WriteLine("How you would like to play the game:\n\n" +
                  "1.Guess between 1-25.\n" +
                  "2.Guess between 1-50.\n" +
                  "3.Choose between two numbers.\n" +
                  "4.Exit the program.\n");
        }
        private static void RiddleMeThis()    //Just a gag.
        {         
            Console.Write("\t   .-''''-..     \r\n" +
                "\t .' .'''.   `.   \r\n" +
                "\t/    \\   \\    `. \r\n" +
                "\t\\    '   |     | \r\n" +
                "\t `--'   /     /  \r\n" +
                "\t      .'  ,-''   \r\n" +
                "\t      |  /       \r\n" +
                "\t      | '        \r\n" +
                "\t      '-'        \r\n" +
                "\t     .--.        \r\n" +
                "\t    /    \\       \r\n" +
                "\t    \\    /       \r\n" +
                "\t     `--'        ");
            Console.WriteLine("Loading Game. . .");    
            Thread.Sleep(1200);
            Console.Clear();
        }
        private static int UserGame(int inputOne, int inputTwo)    // Method to create a random integer between the users choice,
        {
            Random UserRandom = new Random();
            int randomNumber = UserRandom.Next(inputOne, inputTwo);
            return randomNumber;
        }


        //Bortse från denna kod, jag fick inte ihop det alltså, men sparar den ifall jag vill prova någon annan gång :D

        //private static string[] SassyResponse()
        //{
        //    var sassy = new string[] { "Close, but no cigar.", "Is that all you got?", "Not even close bud!", "C'mon, you gotta do better than that?", "I really thought you could make it." };
        //    Random sassyRand = new Random();
        //    sassyRand = sassy.Length();           
        //    return sassy;
        //}



    }

}
