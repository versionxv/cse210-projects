using System;

// Made by Miguel J. Subero Saballo

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>() {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};

    private List<string> _questions = new List<string>() {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and \nresilience. This will help you recognize the power you have and how you can use it in other \naspects of your life.", 30)
    {
        
    }

    public void DisplayQuestions()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);
        int spinWheel = 5;

        while (DateTime.Now < end && _questions.Count != 0)
        {
            string quest = GetRandom(_questions);
            _questions.Remove(quest);
            Console.WriteLine($"> {quest}");
            ShowSpinner(spinWheel);
        } if (_questions.Count == 0)
        {
            Console.WriteLine("");
            Console.WriteLine("Ending early for lack of questions");
        }
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
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"——— {GetRandom(_prompts)} ———");
        Console.WriteLine("");
        Console.Write("When you have something in mind press enter");
        string whatever = Console.ReadLine();
        Console.Clear();

        if (whatever is string)
        {
            DisplayQuestions();
        }

        DisplayEndMessage();
        Thread.Sleep(3000);
        
        return;
    }
}