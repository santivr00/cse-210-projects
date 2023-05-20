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
        
        //Load from file
        Console.Write("Enter the filename to load the journal from: ");
        filename = Console.ReadLine();
        journal.LoadFromFile(filename);
        Console.WriteLine();

        // Write a new entry
        string _randomPrompt = promptGenerator.GetPrompt();
        Console.WriteLine($"Prompt: {_randomPrompt}");
        Console.Write("Response: ");
        string _response = Console.ReadLine();
        string _date = DateTime.Now.ToShortDateString();
        journal.AddEntry(_date, _randomPrompt, _response);
        Console.WriteLine();

        // Display all entries
        Console.WriteLine("Your journal entries:");
        journal.DisplayEntries();

        // Save to file

        Console.Write("Enter the filename to save the journal to: ");
        filename = Console.ReadLine();
        Journal.SaveToFile(journal.entries, filename);
        Console.WriteLine();


    }
} 