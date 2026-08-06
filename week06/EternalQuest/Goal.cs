using System;
using System.Drawing;

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
        return "a";
    }

    public abstract string GetStringRepresentation();
}