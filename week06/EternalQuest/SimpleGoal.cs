using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string explanation, string score) : base(name, explanation, score)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        return;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return "b";
    }
}