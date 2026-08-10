using System;
using System.Drawing;

// Made by Miguel J. Subero Saballo

public abstract class Goal
{
    protected string _shortName;
    protected string _description;

    protected string _points;

    public Goal(string name, string explanation, string score)
    {
        _shortName = name;
        _description = explanation;
        _points = score;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetails()
    {
        return $"[{ (IsComplete() ? "X" : " ")}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public virtual int GetPoints()
    {
        return int.Parse(_points);
    }
}