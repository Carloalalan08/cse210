public class Swimming : Activity
{
    public int Laps { get; set; }

    // Constructor to initialize swimming-specific properties
    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    // Override the abstract methods
    public override double GetDistance() => (Laps * 50) / 1000.0; // Distance in kilometers

    public override double GetSpeed() => (GetDistance() / Duration) * 60; // Speed in kph

    public override double GetPace() => 60 / GetSpeed(); // Pace in minutes per kilometer
}
