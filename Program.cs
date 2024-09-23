namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menuChoice;             // Saves the user input.
            int guess;                  // User guess.
            int guesses = 0;            // Counts the amount of guesses.
            int guessLeft = 5;          // Guesses left.
            bool gameEngine = true;     // Boolean value if the user wants to exit the program.
            int firstNum = 0;           // Integer for when the user wish to decide numbers.
            int secondNum = 0;          // Integer for when the user wish to decide numbers.
            double average = Convert.ToDouble(firstNum + secondNum) / 2;
                      
            Console.WriteLine("---------------------------------\n" +
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

            switch (menuChoice)
            {
                case 1:
                    bool playAgain1 = true;
                    do
                    {
                        Console.Clear();
                        Random RandomNumber = new Random();
                        int rng = RandomNumber.Next(1, 26);
                        Console.WriteLine("Guess on a number between 1 - 25, you have 5 tries to do it.");
                        guess = int.Parse(Console.ReadLine());
                        guesses = 1;
                        guessLeft = 4;
                        bool game1 = true;
                        
                        while (game1 == true)
                        {
                            if (guess > rng && guesses != 5)
                            {
                                Console.WriteLine($"The number is too high, you have {guessLeft} guesses left.");
                                guess = int.Parse(Console.ReadLine());
                            }
                            else if (guess < rng && guesses != 5)
                            {
                                Console.WriteLine($"The number is too low, you have {guessLeft} guesses left.");
                                guess = int.Parse(Console.ReadLine());
                            }
                            else if (guess != rng && guesses == 5)
                            {
                                Console.WriteLine($"\nClose but no cigar! The number i was searching for was {rng}.\n\n" +
                                $"Do you want to try again? Y/N");
                                string playAgain = Console.ReadLine();
                                if (playAgain.ToUpper() == "Y")
                                {
                                    playAgain1 = true;
                                    game1 = false;
                                    guess = 0;
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
                                if (guesses == 1)
                                {
                                    Console.WriteLine($"Congratulations, you made it! It only took you {guesses} guess.");
                                }
                                else         // Tried to make a ternary operator here but it didn't co-operate.
                                {
                                    Console.WriteLine($"Congratulations, you made it! It only took you {guesses} guesses.");
                                }
                                Console.WriteLine("\nDo you want to try again? (Y/N) "); 
                                string playAgain = Console.ReadLine();
                                if (playAgain.ToUpper() == "Y")
                                {
                                    playAgain1 = true;
                                    game1 = false;
                                    guess = 0;
                                    guesses = 0;
                                    guessLeft = 0;
                                }
                                else
                                {
                                    playAgain1 = false;
                                    break;
                                }
                            }
                            guesses++;
                            guessLeft--;
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
                        guess = int.Parse(Console.ReadLine());
                        guesses = 1;
                        guessLeft = 4;
                        bool game2 = true;

                        while (game2 == true)
                        {
                            if (guess > rng && guesses != 5)
                            {
                                Console.WriteLine($"The number is too high, you have {guessLeft} guesses left.");
                                guess = int.Parse(Console.ReadLine());
                            }
                            else if (guess < rng && guesses != 5)
                            {
                                Console.WriteLine($"The number is too low, you have {guessLeft} guesses left.");
                                guess = int.Parse(Console.ReadLine());
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
                                if (guesses == 1)
                                {
                                    Console.WriteLine($"Congratulations, you made it! It only took you {guesses} guess.");
                                }
                                else         // Tried to make a ternary operator here but it didn't co-operate.
                                {
                                    Console.WriteLine($"Congratulations, you made it! It only took you {guesses} guesses.");
                                }
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
                    //bool playAgain3 = true;
                    //do
                    //{
                        
                    //    bool game3 = true;
                    //    //Random UserRandom = new Random();
                    //    //Console.Write("Write your first number: ");
                    //    //firstNum = int.Parse(Console.ReadLine());
                    //    //Console.Write("Write your second number: ");
                    //    //secondNum = int.Parse(Console.ReadLine());
                    //    //int rng3 = UserRandom.Next(firstNum, secondNum);
                    //    UserGame();
                    //    Console.WriteLine(rng3);


                    //    if (firstNum == secondNum)
                    //    {
                    //        Console.WriteLine("You can't pick the same numbers silly.");
                    //    }
                    //    else if (firstNum - secondNum == 1)
                    //    {
                    //        Console.WriteLine("You seem inventive.\n" +
                    //            "Broaden your imagination.");
                    //    }


                    //} while (playAgain3 == true);
                    //break;

                case 4:
                    Console.WriteLine("Thanks for playing my number guessing game.");
                    Console.ReadKey();
                    return;

                default:
                    Console.WriteLine("Please make a correct input.");
                    break;

            }
          { 
            Console.WriteLine("Thanks for playing my number guessing game.");
            Console.ReadKey();
          }
        }
        private static void MenuDisplay()
        {
            Console.WriteLine("Choose below how you would like to play the game:\n\n" +
                  "1.Guess between 1-25.\n" +
                  "2.Guess between 1-50.\n" +
                  "3.Choose between two numbers.\n" +
                  "4.Exit the program.\n");
        }
        //private static int UserGame(int rng3)
        //{
        //    Random UserRandom = new Random();
        //    Console.Write("Write your first number: ");
        //    int firstNum = int.Parse(Console.ReadLine());
        //    Console.Write("Write your second number: ");
        //    int secondNum = int.Parse(Console.ReadLine());
        //    int rng3 = UserRandom.Next(firstNum, secondNum);
        //    return rng3;
        //}



    }

}
