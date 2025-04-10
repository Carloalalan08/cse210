using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public void DisplayMenu()
    {
        // Show main menu options to the user
    }

    public void CreateGoal()
    {
        // Prompt for goal type and details
    }

    public void RecordEvent()
    {
        // Ask user to choose a goal to record an event for
    }

    public void ShowGoals()
    {
        // List all goals with status
    }

    public void SaveGoals(string filename)
    {
        // Save goals to a file
    }

    public void LoadGoals(string filename)
    {
        // Load goals from a file
    }

    public int GetTotalPoints() => _totalPoints;
}
