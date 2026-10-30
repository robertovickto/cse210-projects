using System;

class Program

{

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.WriteLine("");

        Console.Write("Would you like to play the guessing game? (Yes/No) ");

        string willPlay = Console.ReadLine().ToUpper();

        Random randomGenerator = new Random();

        while (willPlay == "YES")

        {

            int randomNumber = randomGenerator.Next(1, 101);

            int guessNumber = 0;

            int numberOfGuesses = 0;

            do

            {

                Console.WriteLine("");

                Console.Write("Guess the magic number: ");

                string guess = Console.ReadLine();

                guessNumber = int.Parse(guess);

                numberOfGuesses += 1;


                if (guessNumber < randomNumber)

                {

                    Console.WriteLine("");

                    Console.WriteLine("Guess a higher number.");

                }

                else if (guessNumber > randomNumber)

                {

                    Console.WriteLine("");

                    Console.WriteLine("Guess a lower number.");

                }

            }

            while (guessNumber != randomNumber);

            Console.WriteLine("");

            Console.WriteLine("You guessed it!");

            Console.WriteLine("");

            Console.WriteLine($"It took {numberOfGuesses} Guesses");

            Console.WriteLine("");

            Console.Write("Would you like to play again? ");

            willPlay = Console.ReadLine().ToUpper();

        }

        Console.WriteLine("");

        Console.WriteLine("Thank you for playing.");

    }

}