using System;
using System.Linq;

// Made by Miguel J. Subero Saballo

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        
        string[] splitWords = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int amount)
    {
        Random random = new Random();

        while (amount != 0)
        {
            int randomIndex = random.Next(0, _words.Count);
            _words[randomIndex].Hide();
           
            amount = amount -1;
        }
    }

    public string GetDisplayText()
    {
        string fullText = string.Join(" ", _words.Select(w => w.GetWText()));
        
        return $"{_reference.GetRText()}: {fullText}";
    }

    public bool IsAllHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
    
}