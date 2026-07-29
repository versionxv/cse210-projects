using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        string name = "Victor";

        string mathTopic = "Addition";
        string page = "15";
        string task = "1-3";
        
        string writingTopic = "Resuming";
        string book = "Don Quijote";

        MathAssignment test = new MathAssignment();

        test.SetStudent(name);
        test.SetTopic(mathTopic);
        test.SetTextbook(page, task);
        Console.WriteLine($"{test.GetSummary()}");
        Console.WriteLine($"Page {test.GetHomeworkList()}");
        Console.WriteLine("");

        WritingAssignment resume = new WritingAssignment();

        resume.SetStudent(name);
        resume.SetTopic(writingTopic);
        resume.SetTittle(book);
        Console.WriteLine($"{resume.GetSummary()}");
        Console.WriteLine($"{resume.GetWritingInformation()}");
    }
}