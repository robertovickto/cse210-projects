using System.IO;

public class Journal

{

    // Attribute

    public List<Entry> _entries = new List<Entry>();

    // Methods

    public void AddEntry(Entry newEntry)

    {

        _entries.Add(newEntry);

    }

    public void DisplayAllEntries()

    {

        Console.WriteLine("These are all your entries:");

        Console.WriteLine();

        for (int i = 0; i < _entries.Count; i++)

        {

            Console.Write($"{i + 1}. ");

            _entries[i].DisplayEntry();

        }
    }

    public void SaveToFile(string filename)

    {

        using (StreamWriter outputFile = new StreamWriter(filename))

        {

            Console.WriteLine("");

            Console.WriteLine($"Saving entry to '{filename}' ...");

            foreach (Entry entry in _entries)

            {

                outputFile.WriteLine($"{entry._entryDate} <> {entry._entryPrompt} <> {entry._userEntry}");

            }

            Console.WriteLine("");

            Console.WriteLine("Saved!");

        }

    }

    public void LoadFromFile(string filename)

    {

        if (!File.Exists(filename))

        {

            Console.WriteLine("");

            Console.WriteLine($"The file '{filename}' could not be found. Please check the filename and try again.");

            return;

        }

        _entries.Clear();

        Console.WriteLine("");

        Console.WriteLine($"Loading entries from '{filename}' ...");

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)

        {

            string[] parts = line.Split(" <> ");

            Entry entry = new Entry();

            entry._entryDate = parts[0];

            entry._entryPrompt = parts[1];

            entry._userEntry = parts[2];

            _entries.Add(entry);

        }

        Console.WriteLine("Loaded!");
    
    }

    public void DeleteEntry(int entryNumber)

    {

        if (entryNumber >= 1 && entryNumber <= _entries.Count)

        {

            _entries.RemoveAt(entryNumber - 1);

            Console.WriteLine("");

            Console.WriteLine($"The entry at {entryNumber} was succesfully deleted.");

        }

        else

        {

            Console.WriteLine("");

            Console.WriteLine("Please check the number you entered and try again.");

        }
    }

}