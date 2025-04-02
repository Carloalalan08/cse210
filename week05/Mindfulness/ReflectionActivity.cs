using System;
using System.Threading;

public class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn from this experience?"
    };

    public ReflectionActivity() : base("Reflection Activity", 
        "This activity helps you reflect on times of strength and resilience.")
    {
    }

    public override void PerformActivity()
    {
        StartActivity();
        
        Random random = new Random();
        Console.WriteLine("\n" + prompts[random.Next(prompts.Length)]);
        
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(questions[random.Next(questions.Length)]);
            PauseWithAnimation(5);
        }

        EndActivity();
    }
}
