using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent(); // Abstract method to record an event and return points

    public abstract bool IsComplete(); // Abstract method to check if the goal is completed

    public string GetDetailsString()
    {
        return $"{_shortName}: {_description}, Points: {_points}";
    }

    public abstract string GetStringRepresentation(); // Abstract method to return a string representation of the goal
}
