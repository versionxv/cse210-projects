using System;

using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 to stop.");
        int newNumber = 0;

        do
        {
           Console.Write("Enter number: ");
           string input = Console.ReadLine();
           newNumber = int.Parse(input);
           numbers.Add(newNumber);
        } while (newNumber != 0);
        
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }

        float average = ((float)total) / (numbers.Count - 1);

        int highest;
        highest = 0;

        foreach (int number in numbers)
        {
            if (number > highest)
            {
                highest = number;
            }
        }

        Console.WriteLine($"The sum is {total}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The highest number you enter was {highest}");
        
    }
}