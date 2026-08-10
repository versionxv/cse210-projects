using System;

//Made by Miguel J. Subero Saballo

class Program
{
    static void Main(string[] args)
    {
        RunningActivity run = new RunningActivity(30, 5);
        CyclingActivity bike = new CyclingActivity(40, 15);
        SwimmingActivity pool = new SwimmingActivity(15, 6);

        List<Activity> training = new List<Activity>();

        training.Add(run);
        training.Add(bike);
        training.Add(pool);

        foreach (Activity excercise in training)
        {
            excercise.GetSummary();
        }
    }
}