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

    public void AddEntry(string date, string prompt, string response)
    {
        Entry entry = new Entry(date, prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine("Date: " + entry._date + " - Prompt: " + entry._prompt);
            Console.WriteLine(entry._response);
            Console.WriteLine();
        }
    }

    public static void SaveToFile(List<Entry> entries, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._date} | {entry._prompt} | {entry._response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] entryParts = line.Split(" | ");
            string date = entryParts[0];
            string prompt = entryParts[1];
            string response = entryParts[2];

            Entry entry = new Entry(date, prompt, response);
            entries.Add(entry);
        }
        Console.WriteLine("Your journal has been loaded");
    }
}