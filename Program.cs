namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = 0;       // Integer for when the user wish to decide numbers.
            int secondNum = 0;      // Integer for when the user wish to decide numbers.
            double average = Convert.ToDouble(firstNum + secondNum) / 2;           
            int menuChoice;         // Saves the user input.
            int guesses;            //Counts the amount of guesses.
            bool gameEngine = true;       //Boolean value if the user wants to exit the program.
            // Ascii ART ?           
            Console.WriteLine("Welcome to the guessing game!\n");
            MenuDisplay();

            while (!int.TryParse(Console.ReadLine(), out menuChoice)) //TryParse so the program can handle improper inputs.
            {                                                       //While loop makes sure the program doesn't move on until correct input.
                Console.Clear();
                Console.WriteLine("Incorrect input, try again.");
                Thread.Sleep(2500);
                Console.Clear();
                MenuDisplay();
                Console.Write("Write a number: ");
            }
            do
                switch (menuChoice)
                {
                    case 1:

                        bool game1;
                        Random rng1 = new Random();
                        rng1.Next(1, 51);
                        Console.WriteLine("Guess on a number between 1 - 50, you have 5 tries to do it.");
                        Console.ReadKey();
                        break;

                    case 2:
                        bool game2;
                        Random rng2 = new Random();
                        rng2.Next(50, 101);
                        Console.WriteLine(rng2);
                        Console.ReadKey();
                        break;

                    case 3:
                        bool game3;
                        Console.Write("Write your first number: ");
                        firstNum = int.Parse(Console.ReadLine());
                        Console.Write("Write your second number: ");
                        secondNum = int.Parse(Console.ReadLine());
                        if (firstNum == secondNum)
                        {
                            Console.WriteLine("You can't pick the same numbers silly.");
                        }
                        else if (firstNum - secondNum == 1)
                        {
                            Console.WriteLine("You seem inventive.\n" +
                                "Broaden your imagination.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Thank you for playing the guessing game!");
                        Console.ReadKey();
                        gameEngine = false;
                        break;
                } while (gameEngine);






        }
        private static void MenuDisplay() 
        {
            Console.WriteLine("Choose below how you would like to play the game:\n\n" +
                  "1.Guess between 1-50.\n" +
                  "2.Guess between 1-100.\n" +
                  "3.Choose between two numbers.\n" +
                  "4.Exit the program.\n");
        }



    }
    
}
