using System;
using System.Globalization;

class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> listOfNumbers = new List<int>();

        int number = 0;

        Console.WriteLine("");

        Console.WriteLine("Enter a list of numbers (could be both positive and negative numbers), type 0 when finished: ");


        do

        {

            Console.WriteLine("");

            Console.Write("Enter number: ");

            string userInput = Console.ReadLine();

            number = int.Parse(userInput);

            if (number != 0)

            {

                listOfNumbers.Add(number);

            }
        }

        while (number != 0);

        int sumOfNumbers = 0;

        int largestNumber = int.MinValue;

        int smallestNumber = int.MaxValue;

        listOfNumbers.Sort();

        foreach (int integer in listOfNumbers)

        {

            sumOfNumbers += integer;

            if (integer > largestNumber)

            {

                largestNumber = integer;

            }

            if (integer < smallestNumber && integer > 0)

            {

                smallestNumber = integer;

            }

        }

        if (listOfNumbers.Count > 0)

        {

            double averageOfNumbers = (double)sumOfNumbers / listOfNumbers.Count;

            Console.WriteLine("");

            Console.WriteLine($"The sum of all numbers is: {sumOfNumbers}");

            Console.WriteLine("");

            Console.WriteLine($"The average of all numbers is: {averageOfNumbers:F3}");

            Console.WriteLine("");

            Console.WriteLine($"The largest number in the list is: {largestNumber}.");

            Console.WriteLine("");

            Console.WriteLine($"The smallest positive number in the list is: {smallestNumber}.");

            Console.WriteLine("");

            Console.WriteLine("The sorted list is: ");

            foreach (int integer in listOfNumbers)

            {

                Console.WriteLine("");

                Console.WriteLine(integer);

            }

        }

        else

        {

            Console.WriteLine("");

            Console.WriteLine("No numbers were entered.");

        }
    }

}