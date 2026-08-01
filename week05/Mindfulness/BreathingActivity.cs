using System;

// Made by Miguel J. Subero Saballo

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your \nmind and focus on your breathing.", 30)
    {
    
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
        int breathIn = 4;
        int breathOut = 6;
        ShowSpinner(spinTime);
        Console.WriteLine("");
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in...");
            ShowCountDown(breathIn);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            ShowCountDown(breathOut);
            Console.WriteLine("");
        }

        DisplayEndMessage();
        Thread.Sleep(3000);
        
        return;
    }
}