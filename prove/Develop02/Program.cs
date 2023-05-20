using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetPrompt();
        Console.WriteLine($"{prompt}");
    }
} 