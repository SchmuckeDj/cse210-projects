using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answerUser = Console.ReadLine();
        int per = int.Parse(answerUser);

        string letter = "";

        if (per >= 90)
        {
            letter = "A";
        }
        else if (per >= 80)
        {
            letter = "B";
        }
        else if (per >= 70)
        {
            letter = "C";
        }
        else if (per >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (per >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time You can do it!");
        }
    }
}