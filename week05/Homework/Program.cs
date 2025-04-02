// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Test MathAssignment class
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary()); // Displays: Roberto Rodriguez - Fractions
        Console.WriteLine(mathAssignment.GetHomeworkList()); // Displays: Section 7.3 Problems 8-19

        Console.WriteLine(); // Blank line for separation

        // Test WritingAssignment class
        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary()); // Displays: Mary Waters - European History
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Displays: The Causes of World War II by Mary Waters
    }
}
