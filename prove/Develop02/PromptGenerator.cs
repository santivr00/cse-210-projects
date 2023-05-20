using System;

class PromptGenerator
{
    private List<string> _prompts;
    private Random _random;
    public PromptGenerator()
    {
        _prompts = new List<string>()
        {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new that I learned today?",
        "What is a goal I want to achieve tomorrow?",
        "How did I show kindness to someone today?",
        "What made me laugh today?",
        "What is something I am grateful for today?",
        "What was the most challenging task I faced today?",
        "Describe a moment of kindness you witnessed or experienced today.",
        "Reflect on a valuable lesson you learned recently.",
        "How did you practice self-care today?",
        "Describe a book, movie, or TV show that made an impact on you recently.",
        "Write about a place you would love to visit and why.",
        "What is a skill or hobby you would like to learn or improve?",
        "Describe a random act of kindness you performed for someone today."
        };

       _random = new Random(); 
    }

    public string GetPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }
}