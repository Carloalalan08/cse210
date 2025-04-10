using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return 0; // Eternal goals never give points on recording events
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName} - {_description}, This goal never completes.";
    }
}
