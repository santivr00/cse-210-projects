using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(string date, string location, string prompt, string response)
    {
        Entry entry = new Entry(date, location, prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("Your journal doesn't have any entries");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("These are your journal entries:");
            Console.WriteLine("");
            foreach (Entry entry in entries)
            {
                Console.WriteLine("Date: " + entry._date + " - Location: " + entry._location);
                Console.WriteLine("Prompt: " + entry._prompt);
                Console.WriteLine(entry._response);
                Console.WriteLine();
            }
        } 
    }

    public static void SaveToFile(List<Entry> entries, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._location} | {entry._prompt} | {entry._response}");
            }
        }
        Console.WriteLine("Journal saved to " + filename);
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] entryParts = line.Split(" | ");
            string date = entryParts[0];
            string location = entryParts[1];
            string prompt = entryParts[2];
            string response = entryParts[3];

            Entry entry = new Entry(date, location, prompt, response);
            entries.Add(entry);
        }
        Console.WriteLine("Your journal has been loaded from " + filename);
    }
}