using System;

// Made by Miguel J. Subero Saballo

public class Video
{
    private string _tittle;
    private string _author;
    private int _seconds;

    private List<Comment> _comments = new List<Comment>();

    public Video(string tittle, string author, int seconds)
    {
        _tittle = tittle;
        _author = author;
        _seconds = seconds;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void GetDisplayText()
    {
        Console.WriteLine($"Video Tittle: {_tittle}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Duration: {_seconds/60} minutes with {_seconds % 60} seconds");
        Console.WriteLine($"Total Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");

        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment.GetUser()}: {comment.GetText()}");
        }
    }
}