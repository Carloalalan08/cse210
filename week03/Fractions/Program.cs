using System;

class Program
{
    static void Main()
    {
        // Testing different constructors
        Fraction f1 = new Fraction();       // 1/1
        Fraction f2 = new Fraction(5);      // 5/1
        Fraction f3 = new Fraction(3, 4);   // 3/4
        Fraction f4 = new Fraction(1, 3);   // 1/3

        // Displaying results
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Testing Getters and Setters
        f1.SetNumerator(7);
        f1.SetDenominator(2);
        Console.WriteLine(f1.GetFractionString()); // Should print 7/2
        Console.WriteLine(f1.GetDecimalValue());   // Should print 3.5
    }
}
