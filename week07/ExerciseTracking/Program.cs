using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some activities
        Activity running = new Running("03 Nov 2022", 30, 3.0);
        Activity cycling = new Cycling("03 Nov 2022", 30, 18.0);
        Activity swimming = new Swimming("03 Nov 2022", 30, 20);

        // Add them to a list
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display summaries for all activities
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
