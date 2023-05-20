using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        string _randomPrompt = promptGenerator.GetPrompt();
        Console.WriteLine($"Prompt: {_randomPrompt}");
        Console.Write("Response: ");
        string _response = Console.ReadLine();
        string _date = DateTime.Now.ToShortDateString();
        journal.AddEntry(_date, _randomPrompt, _response);
        Console.WriteLine();

        Console.WriteLine("Your journal entries:");
        journal.DisplayEntries();
    }
} 