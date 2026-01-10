using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        int num = -1;
        Console.WriteLine(" Enter a list of numbers, type 0 when finished.");

        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                break; // sale del while
            }

            numeros.Add(num);
        }
        int sum = 0;
        foreach (int numero in numeros)
        {
            sum+=numero;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numeros.Count;
        Console.WriteLine($"The average is: {average}");

        // Part 3: Find the max
        // There are several ways to do this, such as sorting the list
        
        int max = numeros[0];
        int smaller =numeros[0];

        foreach (int numb in numeros)
        {
            if (numb > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = numb;
            }
            else if (numb < smaller)
            {
                smaller = numb;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smaller number is: {smaller}");


        numeros.Sort();
        foreach (int numbe in numeros)
        {
           Console.WriteLine(numbe); 
        }
    }
}