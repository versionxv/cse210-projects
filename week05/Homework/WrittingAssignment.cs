using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public void SetTittle(string title)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return _title;
    }
}