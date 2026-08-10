using System;

// Made by Miguel J. Subero Saballo

public class EternalGoal : Goal
{
    public EternalGoal(string name, string explanation, string score) : base(name, explanation, score)
    {

    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName},{_description},{_points}";
    }
}