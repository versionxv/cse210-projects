using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public void SetTextbook(string section, string problems)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSection}, {_problems}";
    }
}