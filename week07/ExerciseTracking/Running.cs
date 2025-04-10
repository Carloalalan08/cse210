public class Running : Activity
{
    public double Distance { get; set; }

    // Constructor to initialize running-specific properties
    public Running(string date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    // Override the abstract methods
    public override double GetDistance() => Distance;

    public override double GetSpeed() => (Distance / Duration) * 60; // Speed in mph

    public override double GetPace() => (Duration / Distance); // Pace in minutes per mile
}
