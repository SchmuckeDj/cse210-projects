using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        string jugar = "s";

        while (jugar == "s")
        {
            int numMagic = rnd.Next(1, 101);
            int guess = -1;


            while (guess != numMagic)
            {
                Console.Write("What is the magic number? ");
                guess = int.Parse(Console.ReadLine());

                if (guess < numMagic)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > numMagic)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.Write("Do you want to play again? (s/n): ");
            jugar = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thanks for playing");
    }
}
