class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        // Main menu loop
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails()
    {
        // Show detailed goal info
    }

    public void CreateGoal()
    {
        // Allow user to create a new goal
    }

    public void RecordEvent()
    {
        // Record an event for a goal
    }

    public void SaveGoals()
    {
        // Save goals to a file
    }

    public void LoadGoals()
    {
        // Load goals from a file
    }
}
