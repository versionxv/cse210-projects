using System;

//Made by Miguel J. Subero Saballo

public class CyclingActivity : Activity
{
    private double _distance;

    public CyclingActivity(double duration, double distance) : base("Cycling", duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double dash = _distance/_time * 60;

        return dash;
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        
        return pace;
    }
}