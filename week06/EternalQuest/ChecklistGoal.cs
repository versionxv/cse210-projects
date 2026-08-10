using System;

// Made by Miguel J. Subero Saballo

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string explanation, string score, int objective, int bonus, int amountCompleted) : base(name, explanation, score)
    {
        _target = objective;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
        }
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
        string status = IsComplete() ? "X" : " ";
        return $"[{status}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override int GetPoints()
    {
        if (_amountCompleted == _target)
        {
            int total = int.Parse(_points) + _bonus;
            return total;
        }
        else return int.Parse(_points);
    }
}