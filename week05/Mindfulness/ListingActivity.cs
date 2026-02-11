using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random = new Random();

    public ListingActivity()
        : base("Listing Activity",
              "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");

        Console.Write("\nYou may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        List<string> items = GetListFromUser();
        _count = items.Count;

        Console.WriteLine($"\nYou listed {_count} items!");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);
        return _prompts[index];
    }

    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        return items;
    }
}
