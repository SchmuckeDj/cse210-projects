using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    private List<string> _unusedQuestions;
    private Random _random = new Random();

    public ReflectingActivity()
        : base("Reflecting Activity",
              "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What did you learn about yourself through this experience?",
            "What made this time different than other times when you were not as successful?",
            "How can you keep this experience in mind in the future?"
        };

        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nReflect on the following questions:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n> {GetRandomQuestion()}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        int index = _random.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index);

        return question;
    }
}
