using System;
using System.ComponentModel;

// Made by Miguel J. Subero Saballo

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    protected int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        bool set = true;
        Console.Clear();
        Console.WriteLine("Welcome to the Goal Manager!");

        while (set == true)
        {
            DisplayPlayerInfo();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create a New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5.Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select your choice: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                CreateGoal();
            }
            else if (input == "2")
            {
                Console.Clear();
                ListGoalDetails();
            }
            else if (input == "3")
            {
                SaveGoals();
            }
            else if (input == "4")
            {
                LoadGoals();
            }
            else if (input == "5")
            {
                Console.Clear();
                RecordEvent();
            }
            else if (input == "6")
            {
                set = false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please pick a valid option.");
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    private void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goals[i].GetStringRepresentation().Split(':')[1].Split(',')[0]}");
        }
    }

    private void ListGoalDetails()
    {
      if (_goals.Count == 0)
        {
            Console.WriteLine("No goals created yet");
            return;
        }
        else
        {
            Console.WriteLine("The goals are:\n");
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i+1}. {_goals[i].GetDetails()}");
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.WriteLine("What type of goal would you like to create? ");
        string pick = Console.ReadLine();

        if (pick == "1")
        {
            Console.WriteLine("What is the name of the goal?");
            string title = Console.ReadLine();
            Console.WriteLine("Give a short description of the goal:");
            string answer = Console.ReadLine();
            Console.WriteLine("How many points does it give?");
            string value = Console.ReadLine();
            _goals.Add(new SimpleGoal(title, answer, value));
            Console.Clear();
            Console.WriteLine($"Goal {title} created!");
            Console.WriteLine("");
        }
        else if (pick == "2")
        {
            Console.WriteLine("What is the name of the goal?");
            string title = Console.ReadLine();
            Console.WriteLine("Give a short description of the goal:");
            string answer = Console.ReadLine();
            Console.WriteLine("How many points does it give?");
            string value = Console.ReadLine();
            _goals.Add(new EternalGoal(title, answer, value));
            Console.Clear();
            Console.WriteLine($"Goal {title} created!");
            Console.WriteLine("");
        }
        else if (pick == "3")
        {
            Console.WriteLine("What is the name of the goal?");
            string title = Console.ReadLine();
            Console.WriteLine("Give a short description of the goal:");
            string answer = Console.ReadLine();
            Console.WriteLine("How many points does it give?");
            string value = Console.ReadLine();
            Console.WriteLine("How many times you need to do it for the bonus points?");
            int times = int.Parse(Console.ReadLine());
            Console.WriteLine("How many bonus points does it give?");
            int bonification = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(title, answer, value, times, bonification, 0));
            Console.Clear();
            Console.WriteLine($"Goal {title} created!");
            Console.WriteLine("");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid choice");
            Console.WriteLine("");
        }
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet to record an event");
            return;
        }

        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.WriteLine("Which goal did you acomplished?");

        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            Goal selectedGoal = _goals[index - 1];
            selectedGoal.RecordEvent();
            int value = selectedGoal.GetPoints();
            _score = _score + value;

            Console.WriteLine("Event recorded");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    private void SaveGoals()
    {
        if (_goals.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("No goals yet to save");
            return;
        }

        Console.WriteLine("\nWhat is the filename you wanna use?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.Clear();
        Console.WriteLine("Goals saved!");
    }

    private void LoadGoals()
    {
        Console.WriteLine("\nWhat is the filename?");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.Clear();
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            if (string.IsNullOrWhiteSpace(line)) continue; 
            string[] parts = line.Split(':');
            string type = parts[0];
            string[] details = parts[1].Split(',');

            if (type == "SimpleGoal")
            {
                SimpleGoal sg = new SimpleGoal(details[0], details[1], details[2]);
                if (bool.Parse(details[3]))
                {
                    sg.RecordEvent();
                }
                _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal(details[0], details[1], details[2]);
                _goals.Add(eg);
            }
            else if (type == "ChecklistGoal")
            {
                int bonusA = int.Parse(details[3]);
                int targetA = int.Parse(details[4]);
                int currentProgressA = int.Parse(details[5]);
                ChecklistGoal cg = new ChecklistGoal(details[0], details[1], details[2], targetA, bonusA, currentProgressA);
                _goals.Add(cg);
            }
        }
        Console.Clear();
        Console.WriteLine("Goals loaded successfully.");
    }
}