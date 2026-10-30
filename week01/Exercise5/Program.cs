using System;

class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        Console.WriteLine("");

        DisplayMessage();

        Console.WriteLine("");

        string fullName = PromptUserName();

        Console.WriteLine("");

        int favouriteNumber = PromptUserNumber();

        int squareOfNumber = SquareNumber(favouriteNumber);

        Console.WriteLine("");

        DisplayResult(fullName, squareOfNumber);

    }

    static void DisplayMessage()

    {

        Console.WriteLine("Welcome to the program");

    }

    static string PromptUserName()

    {

        Console.Write("Please enter your full name: ");

        string fullName = Console.ReadLine();

        return fullName;

    }

    static int PromptUserNumber()

    {

        Console.Write("Please enter your favorite number: ");

        int favouriteNumber = int.Parse(Console.ReadLine());

        return favouriteNumber;

    }

    static int SquareNumber(int favouriteNumber)

    {

        int squareOfNumber = favouriteNumber * favouriteNumber;

        return squareOfNumber;

    }

    static void DisplayResult(string fullName, int squareOfNumber)

    {

        Console.WriteLine($"{fullName}, the square of your favourite number is: {squareOfNumber}");

    }

}