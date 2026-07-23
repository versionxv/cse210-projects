using System;

// Made by Miguel J. Subero Saballo
// I made that the program gives you back duration of the videos in minutes and seconds.

class Program
{
    static void Main(string[] args)
    {
        string test = "Avatar";
        string author = "Aang";
        int duration = 120;

        Video v1 = new Video(test, author, duration);

        string dude = "AA69";
        string text = "I love your videos";

        Comment c1 = new Comment(dude, text);

        v1.AddComment(c1);

        string dude2 = "NewUser";
        string text2 = "Is very funny";
        
        Comment c2 = new Comment(dude2, text2);

        v1.AddComment(c2);

        string dude3 = "Banana";
        string text3 = "I hate your videos";
        
        Comment c3 = new Comment(dude3, text3);

        v1.AddComment(c3);

        v1.GetDisplayText();

        Console.WriteLine("");

        string test2 = "Sopa infita";
        string author2 = "Naruto";
        int duration2 = 1020;

        Video v2 = new Video(test2, author2, duration2);

        string dude4 = "AJAJAJA";
        string text4 = "I love it";

        Comment c4 = new Comment(dude4, text4);

        v2.AddComment(c4);

        string dude5 = "NewUser";
        string text5 = "Is not funny";
        
        Comment c5 = new Comment(dude5, text5);

        v2.AddComment(c5);

        string dude6 = "Banana";
        string text6 = "I hate it";
        
        Comment c6 = new Comment(dude6, text6);

        v2.AddComment(c6);

        string dude7 = "YourMAMA";
        string text7 = "I do agree";
        
        Comment c7 = new Comment(dude7, text7);

        v2.AddComment(c7);

        v2.GetDisplayText();

        Console.WriteLine("");

        string test3 = "How to create water";
        string author3 = "6767";
        int duration3 = 304;

        Video v3 = new Video(test3, author3, duration3);

        string dude8 = "TheDARK";
        string text8 = "Try again";

        Comment c8 = new Comment(dude8, text8);

        v3.AddComment(c8);

        string dude9 = "NoIDEAS";
        string text9 = "Can you share it in X?";
        
        Comment c9 = new Comment(dude9, text9);

        v3.AddComment(c2);

        string dude10 = "Monarca";
        string text10 = "Imagine it";
        
        Comment c10 = new Comment(dude10, text10);

        v3.AddComment(c10);

        v3.GetDisplayText();


    }
}