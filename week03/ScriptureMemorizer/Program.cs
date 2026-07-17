using System;
using System.Linq;

// Made by Miguel J. Subero Saballo

// Improved it by making possible to enter your own scripture.
// Also made it so if you hide "hope," the amount of "_" ignores "," and other symbols so you can remember the lenght.

class Program
{
    static void Main(string[] args)
    {
        string title = "";
        int chapterNumber = -1;
        int startingVerse = -1;
        int finalVerse = -1;
        string content = "";

        int times = -1;


        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Would you like to use Moroni 7:42-43 or customize the learning scripture?");
        Console.Write("(Type 0 if you want to use other scripture of your choice): ");
        string input = Console.ReadLine();
        

        if (input == "0")
        {
           Console.Write("Type the Book name: ");
           title = Console.ReadLine();
           Console.WriteLine("");

           Console.Write("Type the chapter: ");
           chapterNumber = int.Parse(Console.ReadLine());
           Console.WriteLine("");

           Console.Write("Yype the starting verse: ");
           startingVerse = int.Parse(Console.ReadLine());
           Console.WriteLine("");

           Console.Write("Type the ending verse (Type 0 if only had one verse): ");
           finalVerse = int.Parse(Console.ReadLine());
           Console.WriteLine("");

           Console.Write("Type the text of the scripture: ");
           content = Console.ReadLine();
           Console.WriteLine("");
        } else
        {
            title = "Moroni";
            chapterNumber = 7;
            startingVerse = 42;
            finalVerse = 43;
            content = "Wherefore, if a man have faith he must needs have hope; for without faith there cannot be any hope. And again, behold I say unto you that he cannot have faith and hope, save he shall be meek, and lowly of heart.";
        }
        
        Reference nReference;
        if (finalVerse != 0)
        {
            nReference = new Reference(title, chapterNumber, startingVerse, finalVerse);
        } else
        {
            nReference = new Reference(title, chapterNumber, startingVerse);
        }

        Console.WriteLine("");
        while (times < 1)
        {
            Console.Write("How many words would you like to hide each time (Can repeat)? ");
            times = int.Parse(Console.ReadLine());
        }
        
        Scripture nScripture = new Scripture(nReference, content);
        Console.Clear();

        while (!nScripture.IsAllHidden() && input != "quit")
        {
            Console.WriteLine(nScripture.GetDisplayText());
            Console.WriteLine("");
            Console.Write("Press enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            nScripture.HideRandomWords(times);
            Console.Clear();

        }
    }
}