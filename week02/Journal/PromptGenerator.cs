using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What made you happy today?",
        "What did you learn today?",
        "What was the best part of your day?"
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
