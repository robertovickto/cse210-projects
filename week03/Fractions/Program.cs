using System;

class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine(f1.GetFractionString());  // 1/1
        Console.WriteLine(f1.GetDecimalValue());    // 1
        Console.WriteLine(f2.GetFractionString());  // 6/1
        Console.WriteLine(f2.GetDecimalValue());    // 6
        Console.WriteLine(f3.GetFractionString());  // 6/7
        Console.WriteLine(f3.GetDecimalValue());    // 0.857142857142857
    }
}