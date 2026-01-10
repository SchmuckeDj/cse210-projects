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
                break; 
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

        
        int max = numeros[0];
        int smaller =numeros[0];

        foreach (int numb in numeros)
        {
            if (numb > max)
            {
                
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