using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Select a random number: ");
        int randomNumber = int.Parse(Console.ReadLine());
        int guessedNumber = -1;

        while (guessedNumber != randomNumber)
        {
            Console.Write("Take a guess ");
            guessedNumber = int.Parse(Console.ReadLine());

            if (randomNumber > guessedNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (randomNumber < guessedNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it");
            }
        }
        
    }
}