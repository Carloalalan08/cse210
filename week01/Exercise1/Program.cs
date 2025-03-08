// Mon Carlo R. Alalan
// CSE210 Team 02 - Wednesdays 16:00 (UTC-0)
// C# Programming Exercise 1—Variables, Input, and Output


using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}