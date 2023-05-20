using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        string filename;

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display my journal");
            Console.WriteLine("3. Save my journal to a file");
            Console.WriteLine("4. Load my journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                // Write a new entry
                case "1":
                    string _randomPrompt = promptGenerator.GetPrompt();
                    Console.WriteLine($"Prompt: {_randomPrompt}");
                    Console.Write("Response: ");
                    string _response = Console.ReadLine();
                    string _date = DateTime.Now.ToShortDateString();
                    journal.AddEntry(_date, _randomPrompt, _response);
                    Console.WriteLine("Entry saved.");
                    Console.WriteLine();
                    break;
                // Display all entries
                case "2":
                    Console.WriteLine("These are your journal entries:");
                    Console.WriteLine("");
                    journal.DisplayEntries();
                    break;
                // Save to file
                case "3":
                    Console.Write("Enter the filename to save the journal to: ");
                    filename = Console.ReadLine();
                    Journal.SaveToFile(journal.entries, filename);
                    Console.WriteLine();
                    break;
                //Load from file
                case "4":
                    Console.Write("Enter the filename to load the journal from: ");
                    filename = Console.ReadLine();
                    journal.LoadFromFile(filename);
                    Console.WriteLine();
                    break;
                //Quit
                case "5":
                    return;
                //Invalid choice
                default:
                    Console.WriteLine("Please try again");
                    break;
            }
        }
    }
} 