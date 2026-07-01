using System;
using System.IO.Pipelines;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your score? ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        string result = "";

        if (number >= 90)
        {
            result = "A";
        }

        else if (number >= 80)
        {
            result = "B";
        }

        else if (number >= 70)
        {
            result = "C";
        }

        else if (number >= 60)
        {
            result = "D";
        }

        else
        {
            result = "F";
        }

        Console.WriteLine($"Your final score is {result}");

        if (result == "A")
        {
            Console.WriteLine("You're amazing!");
        }

        else if (result == "F")
        {
            Console.WriteLine("You didn't pass, make more effort next time.");
        }

        else
        {
            Console.WriteLine("Keep the good work! Improve more!");
        }
    }
}