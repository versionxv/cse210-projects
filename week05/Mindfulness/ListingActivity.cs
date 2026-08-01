using System;
using System.Collections.Generic;

// Made by Miguel J. Subero Saballo

public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string>() {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many \nthings as you can in a certain area", 30)
    {
        
    }

    public void GetList()
    {
        List<string> userList = new List<string>();

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string newLine = Console.ReadLine();
            userList.Add(newLine);
        }
        _count = userList.Count;
        Console.WriteLine("");
        Console.WriteLine($"You listed {_count} items!");

        return;
    }

    public void Run()
    {
        DisplayStartMessage();
        string answer = Console.ReadLine();
        if (int.TryParse(answer, out int result))
        {
            SetNewTime(result);
        } else
        {
            Console.WriteLine("Invalid time value, starting default (30 seconds)");
            Thread.Sleep(2000);
        }

        Console.Clear();
        Console.WriteLine("Get ready...");
        int spinTime = 3;
        ShowSpinner(spinTime);
        Console.WriteLine("");
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"——— {GetRandom(_prompts)} ———");
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        ShowCountDown(spinTime);
        GetList();

        DisplayEndMessage();
        Thread.Sleep(3000);
        
        return;
    }
}