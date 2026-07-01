using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareValue = SquareNumber(userNumber);

        DisplayResult(userName, squareValue);
    }

    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string data = Console.ReadLine();
        int number;
        number = int.Parse(data);

        return number;
    }

    static int SquareNumber(int value)
    {
        int square;
        square = value * value;

        return square;
    }

    static void DisplayResult(string text, int digit)
    {
        Console.WriteLine($"{text}, the square of your number is {digit}.");
    }
}