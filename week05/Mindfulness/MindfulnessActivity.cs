using System;
using System.Threading;

public abstract class MindfulnessActivity
{
    protected string activityName;
    protected string description;
    protected int duration;

    public MindfulnessActivity(string name, string desc)
    {
        activityName = name;
        description = desc;
    }

    public void StartActivity()
    {
        Console.WriteLine($"\nStarting {activityName}...");
        Console.WriteLine(description);
        Console.Write("Enter the duration (in seconds): ");
        duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready...");
        PauseWithAnimation(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGreat job! You've completed the activity.");
        Console.WriteLine($"You spent {duration} seconds on {activityName}.");
        PauseWithAnimation(3);
    }

    protected void PauseWithAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public abstract void PerformActivity();
}
