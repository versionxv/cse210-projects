using System;
using System.Dynamic;

// Made by Miguel J. Subero Saballo

// First, I made it so the questions of Reflecting Activity don't repeat and end early if you see all.
// Second, I optimized the program. I noticed GetRandomPrompt existed twice in the design and saw a chance to
// improve upon it. So I made a GetRandom in Activity that then is called by Reflecting (Twice) and Listing (once)
// in order to work. Basically saving at least 20 lines of code and uneeded repetition.

class Program
{
    static void Main(string[] args)
    {
        bool x = true;
        
        while (x)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Breathing Activity");
            Console.WriteLine(" 2. Start Listing Activity");
            Console.WriteLine(" 3. Start Reflection Activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select an option from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity test = new BreathingActivity();
                test.Run();

            } else if (input == "2")
            {
                ListingActivity test = new ListingActivity();
                test.Run();

            } else if (input == "3")
            {
                ReflectingActivity test = new ReflectingActivity();
                test.Run();

            } else
            {
                x = false;
            }
        }
       
    }
}