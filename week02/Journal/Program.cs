using System;
using System.IO;
using System.Text.Json;

// Made by Miguel J. Subero Saballo
// Improve it by making it save the information in json format and loading json formats as well.

class Program
{
    static void Main(string[] args)
    {
        string input;
        input = "";
        DateTime currentTime = DateTime.Now;

        Prompt nPrompt = new Prompt();
        Journal journal = new Journal();
        
        while (input != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1-Write a new entry");
            Console.WriteLine("2-Display all entries");
            Console.WriteLine("3-Load a Journal");
            Console.WriteLine("4-Save in or as a new Journal");
            Console.WriteLine("5-Quit");
            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

            Entry set = new Entry();

            if (input == "1")
            {
                Console.WriteLine("");
                set._promptText = nPrompt.GetRandomPrompt();
                Console.WriteLine($"{set._promptText}");
                Console.Write(">");
                set._date = currentTime.ToShortDateString();
                set._entryText = Console.ReadLine();
                journal.AddEntry(set);
                Console.WriteLine("");
            }

            if (input == "2")
            {
                Console.WriteLine("");
                journal.DisplayAll();
            }

            if (input == "3")
            {
                Console.WriteLine("");
                Console.Write("What is the filename? ");
                string loadName = Console.ReadLine();
                journal.LoadFromFile(loadName);
            }

            if (input == "4")
            {
                Console.Write("What is the filename? ");
                string saveName = Console.ReadLine();
                journal.SaveToFile(saveName);
            }
        }

    }
}