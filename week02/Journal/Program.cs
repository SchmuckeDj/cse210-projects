// EXCEEDING CORE REQUIREMENTS:
// In addition to the basic journal functionality, this program includes

// This allows the user to keep their journal entries even after the program
// is closed.

// The program also uses a PromptGenerator 

// These features go beyond simply writing and displaying journal entries



using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();

                entry._prompt = promptGenerator.GetPrompt();
                Console.WriteLine(entry._prompt);

                entry._text = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (choice == "4")
            {
                Console.Write("Filename: ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == "5")
            {
                running = false;
            }
        }
    }
}
