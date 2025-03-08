// Mon Carlo R. Alalan
// CSE210 Team 02 - Wednesdays 16:00 (UTC-0)
// C# Programming Exercise 5—Functions
using System;

class Program
{
    // DisplayWelcome: Displays the message, "Welcome to the Program!"
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // PromptUserName: Asks for and returns the user's name (as a string)
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // PromptUserNumber: Asks for and returns the user's favorite number (as an integer)
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber;
        while (!int.TryParse(Console.ReadLine(), out userNumber))
        {
            Console.Write("Please enter a valid number: ");
        }
        return userNumber;
    }

    // SquareNumber: Accepts an integer as a parameter and returns that number squared (as an integer)
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // DisplayResult: Accepts the user's name and the squared number and displays them.
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}");
    }

    static void Main()
    {
        // Call functions and save return values
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }
}
