using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.Write("What is the magic number? ");
        string input = Console.ReadLine();
        int guess = int.Parse(input);

        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Guess lower!");
                input = Console.ReadLine();
                guess = int.Parse(input);
            }

            else
            {
                Console.WriteLine("Guess higher!");
                input = Console.ReadLine();
                guess = int.Parse(input);
            }
        }

        Console.WriteLine($"That's right! The Magic number is {number}");
    }
}