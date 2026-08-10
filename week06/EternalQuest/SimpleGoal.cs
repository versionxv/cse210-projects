using System;

// Made by Miguel J. Subero Saballo

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string explanation, string score) : base(name, explanation, score)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }
}