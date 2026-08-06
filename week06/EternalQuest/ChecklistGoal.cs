using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string explanation, string score, int objective, int bonus) : base(name, explanation, score)
    {
        _target = objective;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        return;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        } else
        {
            return false;
        }
    }

    public override string GetDetails()
    {
        return "b";
    }

    public override string GetStringRepresentation()
    {
        return "b";
    }
}