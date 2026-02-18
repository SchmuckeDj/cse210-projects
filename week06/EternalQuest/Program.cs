using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // The program follows full polymorphism using a base Goal class.
        // Checklist goals award bonus points when completed.
        // The design strictly follows the provided UML class diagram.

        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
