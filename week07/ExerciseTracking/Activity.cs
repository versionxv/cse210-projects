using System;
using System.Data;

//Made by Miguel J. Subero Saballo

public abstract class Activity
{
    protected string _name;
    protected double _time;
    protected string _date;
    public Activity(string title, double duration)
    {
        _name = title;
        _time = duration;
        _date = $"{DateTime.Now:dd/MM/yyyy}";
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_time} min): Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
}