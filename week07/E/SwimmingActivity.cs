using System;

//Made by Miguel J. Subero Saballo

public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(double duration, double laps) : base("Swimming", duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        double dash = GetDistance()/_time * 60;

        return dash;
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        
        return pace;
    }
}