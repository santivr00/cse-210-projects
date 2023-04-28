using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their name.
        Console.Write("What's your first name? ");
        string FirstName = Console.ReadLine();

        Console.Write("What's your last name? ");
        string LastName = Console.ReadLine();

        Console.WriteLine($"Your name is {LastName}, {FirstName} {LastName}.");
    }
}