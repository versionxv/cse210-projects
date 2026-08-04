using System;

public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double measure) : base(color)
    {
        _radius = measure;
    }

    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}