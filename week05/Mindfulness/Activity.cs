using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    protected int GetDuration()
    {
        return _duration;
    }

    protected string GetName()
    {
        return _name;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!");
        ShowSpinner(3);

        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name}.");
        SaveToLog();
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Count;
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    private void SaveToLog()
    {
        File.AppendAllText("activity_log.txt",
            $"{DateTime.Now}: Completed {_name} for {_duration} seconds\n");
    }
}
