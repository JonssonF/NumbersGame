namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int average;
            int secondNum;
            int menuChoice;
            bool gameEngine = true;
                // Ascii ART question blinkande grön tack.
            Console.WriteLine("Välkommen till gissningsspelet!\n" +
                "Välj nedan hur du vill spela spelet:\n\n" +
                "1.Gissa mellan 1-50.\n" +
                "2.Gissa mellan 1-100.\n" +
                "3.Välj själv mellan vilka 2 tal du ska gissa på.\n" +
                "4.Avsluta programmet.");
            
            while (!int.TryParse(Console.ReadLine(), out menuChoice)) //TryParse so the program can handle improper inputs.
            {                                                       //While loop makes sure the program doesn't move on until correct input.
                Console.Clear();
                Console.WriteLine("Felaktigt val, försök igen.");
                Console.Write("Skriv en siffra: ");
            }            
            if (gameEngine)
                switch (menuChoice)
                {
                    case 1:
                        bool game1;                        
                        Random rng1 = new Random();
                        rng1.Next(1,51);
                        Console.WriteLine(rng1.Next(1, 51));
                        Console.ReadKey();
                        break;

                    case 2:
                        bool game2;
                        Random rng2 = new Random();
                        rng2.Next(50,101);
                        Console.WriteLine(rng2);
                        Console.ReadKey();
                        break;                   
                        
                    case 3:
                        bool game3;
                        Console.Write("Skriv in ett tal: ");
                        firstNum = Convert.ToInt32(Console.ReadLine);
                        Console.Write("Skriv in ett till tal: ");
                        secondNum = Convert.ToInt32(Console.ReadLine);
                        if (firstNum == secondNum)
                        {
                            Console.WriteLine("Du kan inte välja samma tal dumbom.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Tack för att ni valde att spela gissningsspelet!");
                        Console.ReadKey();
                        gameEngine = false;
                        break;
                }
            



            
        }
    }
}
