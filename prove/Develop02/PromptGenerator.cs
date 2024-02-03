using System;

public class PromptGenerator 
{
    public string[] _prompts = new string[]
    {
        "Who was the most interesting person I interacted with today? ",
        "What was the best part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What was the strongest emotion I felt today? ",
        "If I had one thing I could do over today, what would it be? ",
        "What did I learn today? ",
        "Who inspires you? ",
        "A favorite moment of your day: ",
        "What brings you joy? ",
        "What was the most interesting thing you saw or heard today? ",
        "What was the funniest thing you did today? ",
        "What was the most challenging thing you faced today? ",
        "What am I grateful for today? ",
        "What are you most proud of? ",
        "What do I hope to get out of today? ",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}
