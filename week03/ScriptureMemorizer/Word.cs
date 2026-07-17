using System;
using System.Linq;

// Made by Miguel J. Subero Saballo

public class Word
{
    private string _text;
    private bool _isHidden {get; set;}

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetWText()
    {
        if (_isHidden == true)
        {
            int quantity = _text.Length;
            char[] check = { '.', ',', ';'};
            if (_text.IndexOfAny(check) != -1)
            {
                quantity = quantity -1;
            }
            return new string('_', quantity);
        }
        
        return _text;
    }
}