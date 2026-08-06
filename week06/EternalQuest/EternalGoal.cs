using System;

public class EternalGoal : Goal
{
    EternalGoal(string name, string explanation, string score) : base(name, explanation, score)
    {

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