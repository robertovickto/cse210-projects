using System;
using System.Diagnostics;

class Program

{

    // I added an option to delete entries, by accessing their index.

    // I added code in the journal class to check that the file from which entries are being loaded, exists, and if not print and error message.

    // I wrote code to handle situations where the user enters invalid options to prompts (menu choice and delete entry choice).

    static void Main(string[] args)

    {

        Journal journal = new Journal();

        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "";

        string filename = "";

        Console.WriteLine("Welcome to your journal, a place where you can be yourself without judgement");

        do

        {

            Console.WriteLine("");

            Console.WriteLine("Please select one of the following options by typing in a number that corresponds with your choice:");

            Console.WriteLine("");

            Console.WriteLine("1. New entry");

            Console.WriteLine("2. Display All Entries");

            Console.WriteLine("3. Save entries to file");

            Console.WriteLine("4. Load entries from a file");

            Console.WriteLine("5. Delete entry");

            Console.WriteLine("6. Quit");

            Console.WriteLine("");

            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            Console.WriteLine("");

            switch (choice)

            {

                case "1":

                    {

                        Entry newEntry = new Entry();

                        newEntry._entryDate = DateTime.Now.ToShortDateString();

                        newEntry._entryPrompt = promptGenerator.GetRandomPrompt();

                        Console.WriteLine(newEntry._entryDate);

                        Console.WriteLine("");

                        Console.WriteLine(newEntry._entryPrompt);

                        Console.WriteLine("");

                        Console.Write(">>> ");

                        newEntry._userEntry = Console.ReadLine();

                        journal.AddEntry(newEntry);

                        break;

                    }

                case "2":

                    {

                        journal.DisplayAllEntries();

                        break;

                    }

                case "3":

                    {

                        Console.Write("Whats the name of the file you want to save to?: >>> ");

                        filename = Console.ReadLine();

                        journal.SaveToFile(filename);

                        break;

                    }

                case "4":

                    {

                        Console.Write("Whats the name of the file you want to load from?: >>> ");

                        filename = Console.ReadLine();

                        journal.LoadFromFile(filename);

                        break;

                    }

                case "5":

                    {

                        journal.DisplayAllEntries();

                        Console.WriteLine("");

                        Console.Write("Enter the number that corresponds to the entry you would like to delete: >>> ");

                        string userInput = Console.ReadLine();

                        int entryNumber = 0;

                        if (int.TryParse(userInput, out entryNumber))

                        {

                            journal.DeleteEntry(entryNumber);

                        }

                        else

                        {

                            Console.WriteLine("");

                            Console.WriteLine($"You entered '{userInput}', which is not a number, please try again and enter a number.");

                        }

                        break;

                    }

                case "6":

                    {

                        Console.WriteLine("Goodbye! Please come back again and share parts of who you are today, with who you become tomorrow.");

                        break;

                    }

                default:

                    {

                        Console.WriteLine($"You have entered '{choice}'. Please enter a number from 1 to 6.");

                        break;

                    }

            }

        }

        while (choice != "6");

    }

}