using System;

class Program

{

    static void Main(string[] args)

    {

        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("");

        Console.Write("Please enter you grade percentage: ");

        string studentGrade = Console.ReadLine();

        int studentGradeNumber = int.Parse(studentGrade);

        string studentGradeLetter = "";

        if (studentGradeNumber >= 90)

        {

            studentGradeLetter = "A";

        }

        else if (studentGradeNumber >= 80)

        {

            studentGradeLetter = "B";

        }

        else if (studentGradeNumber >= 70)

        {

            studentGradeLetter = "C";

        }

        else if (studentGradeNumber >= 60)

        {

            studentGradeLetter = "D";

        }

        else if (studentGradeNumber < 60)

        {

            studentGradeLetter = "F";

        }

        string studentGradeSign = "";

        if (studentGradeNumber < 90 && studentGradeNumber >= 60 && studentGradeNumber % 10 >= 7)

        {

            studentGradeSign = "+";

        }

        else if (studentGradeNumber >= 60 && studentGradeNumber % 10 <= 3 && studentGradeNumber < 100)

        {

            studentGradeSign = "-";

        }

        else

        {

            studentGradeSign = "";

        }

        Console.WriteLine("");

        Console.WriteLine($"Your grade letter is {studentGradeLetter}{studentGradeSign}");

        if (studentGradeNumber >= 70)

        {

            Console.WriteLine("");

            Console.WriteLine("Congratulations! You passed this course.");

        }

        else

        {

            Console.WriteLine("");

            Console.WriteLine("Sorry! You didn't pass the course. You should take it again, and I'm sure you will make it next time.");

        }

    }
}