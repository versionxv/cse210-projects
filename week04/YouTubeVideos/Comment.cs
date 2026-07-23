using System;

// Made by Miguel J. Subero Saballo

public class Comment
{
    private string _userName;
    private string _text;

    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }

    public string GetUser()
    {
        return _userName;
    }

    public string GetText()
    {
        return _text;
    }
}