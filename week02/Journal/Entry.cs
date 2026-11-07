public class Entry

{

    // Attributes

    public string _entryDate;

    public string _entryPrompt;

    public string _userEntry;

    // Method

    public void DisplayEntry()

    {

        Console.WriteLine($"On {_entryDate} you answered the question:");

        Console.WriteLine(_entryPrompt);

        Console.WriteLine("You said:");

        Console.WriteLine(_userEntry);

        Console.WriteLine("");

    }

}