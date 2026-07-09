using System;
using System.IO;
using System.Text.Json;

// Made by Miguel J. Subero Saballo
// This works with Json format

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        if (newEntry == null) return;

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry set in _entries)
        {
            set.Display();
            Console.WriteLine("");
        }
    }

    public void LoadFromFile(string lName)
    {
        if (!File.Exists(lName))
        {
            Console.WriteLine($"{lName} doesn't exist.");
            return;
        }

        string jsonRead = File.ReadAllText(lName);

        var details = new JsonSerializerOptions {IncludeFields = true};

        _entries = JsonSerializer.Deserialize<List<Entry>>(jsonRead, details);

        Console.WriteLine($"Loaded entries from {lName}.");
        Console.WriteLine("");
    }

    public void SaveToFile(string sName)
    {
       var options = new JsonSerializerOptions {WriteIndented = true, IncludeFields = true};

       string jsonText = JsonSerializer.Serialize(_entries, options);

       File.WriteAllText(sName, jsonText);

       Console.WriteLine($"Entries saved in {sName}.");
       Console.WriteLine("");
    }
    
}