using System;

public class Fraction
{
    private int _top;
    private int _bot;

    public Fraction()
    {
        _bot = 1;
        _top = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bot = 1;
    }

    public Fraction(int top, int bot)
    {
        _top = top;
        _bot = bot;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int value)
    {
        _top = value;
    }

    public int GetBot()
    {
        return _bot;
    }

    public void SetBot(int value)
    {
        _bot = value;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bot}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bot;
    }
}