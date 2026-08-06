using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        
    }

    public void Start()
    {
        bool set = true;
        Console.WriteLine("Welcome to the Goal Manager!");

        while (set == true)
        {
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create a New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5.Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select your choice: ");
            string input = Console.ReadLine();

            while (input == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("The types of Goals are:");
                Console.WriteLine(" 1. Simple Goal");
                Console.WriteLine(" 2. Eternal Goal");
                Console.WriteLine(" 3. Checklist Goal");
                Console.Write("What type of goal would you like to create? ");
                string pick = Console.ReadLine();

                if (pick == "1")
                {
                    return;

                } else if (pick == "2")
                {
                    return;

                } else if (pick == "3")
                {
                    return;

                } else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please pick a valid option");
                }

            } else if (input == "2")
            {
                return;

            } else if (input == "3")
            {
                return;

            } else if (input == "4")
            {
                return;

            } else if (input == "5")
            {
                return;

            } else if (input == "6")
            {
                set = false;
            } else
            {
                Console.WriteLine("");
                Console.WriteLine("Please pick a valid option");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        return;
    }

    public void ListGoalNames()
    {
        return;
    }

    public void ListGoalDetails()
    {
      return;   
    }

    public void CreateGoal()
    {
        return;
    }

    public void RecordEvent()
    {
        return;
    }

    public void SaveGoals()
    {
        return;
    }

    public void LoadGoals()
    {
        return;
    }
}