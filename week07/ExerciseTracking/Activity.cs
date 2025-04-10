using System;

public abstract class Activity
{
    public string Date { get; set; }
    public int Duration { get; set; } // Duration in minutes
    
    // Constructor to initialize the date and duration
    public Activity(string date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    // Abstract methods to be overridden in derived classes
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Method to generate the summary
    public virtual string GetSummary()
    {
        return $"{Date} {this.GetType().Name} ({Duration} min) - Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
