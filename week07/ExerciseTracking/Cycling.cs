public class Cycling : Activity
{
    public double Speed { get; set; }

    // Constructor with correct parameters
    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }

    // Override the abstract methods
    public override double GetDistance() => (Speed * Duration) / 60; // Distance in miles

    public override double GetSpeed() => Speed; // Speed in mph

    public override double GetPace() => 60 / Speed; // Pace in minutes per mile
}
