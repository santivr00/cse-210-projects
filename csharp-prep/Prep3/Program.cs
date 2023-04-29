using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
        
            int guessedNumber = -1;

            while (guessedNumber != magicNumber)
            {
                Console.Write("Take a guess ");
                guessedNumber = int.Parse(Console.ReadLine());

                if (magicNumber > guessedNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guessedNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it");
                }
            }
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
        Console.WriteLine("End of the game");
    }
}