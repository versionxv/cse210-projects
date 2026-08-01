using System;

// Made by Miguel J. Subero Saballo

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity(string title, string explanation, int time)
    {
        _name = title;
        _description = explanation;
        _duration = time;
    }

    protected void SetNewTime(int timer)
    {
        _duration = timer;
    }

    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? (Default is 30 seconds) ");
        
        return;
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine("\nCongratulations!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activiy.");
        
        return;
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> spin = new List<string>() {"|", "/", "—", "\\"};
        int i = 0;
        
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        while (DateTime.Now < end)
        {
            string bar = spin[i];
            Console.Write(bar);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= spin.Count)
            {
                i = 0;
            }
        }
    }

    protected void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }

    protected string GetRandom(List<string> someList)
    {
        Random random = new Random();
        int randomIndex = random.Next(0, someList.Count);
        string prompt = someList[randomIndex];

        return prompt;
    }
}