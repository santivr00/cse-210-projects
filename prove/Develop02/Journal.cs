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
}