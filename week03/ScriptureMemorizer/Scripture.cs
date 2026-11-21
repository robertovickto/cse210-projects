using System;

using System.Collections.Generic;

public class Scripture

{

    // Attributes

    private Reference _reference;

    private List<Word> _words;

    private Random _random = new Random();

    // Constructors

    public Scripture(Reference reference, string text)

    {

        _reference = reference;

        _words = new List<Word>();

        string[] parts = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        foreach (string part in parts)

        {

            _words.Add(new Word(part));

        }

    }

    // Methods

    public void HideRandomWords(int numberToHide)

    {

        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)

        {

            if (!word.IsHidden())

            {

                visibleWords.Add(word);

            }

        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)

        {

            int index = _random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            visibleWords.RemoveAt(index);

        }

    }

    public string GetDisplayText()

    {

        string fullText = _reference.GetDisplayText();

        foreach (Word word in _words)

        {

            fullText += " " + word.GetDisplayText();

        }

        return fullText;

    }

    public bool IsCompletelyHidden()

    {

        foreach (Word word in _words)

        {

            if (!word.IsHidden())

            {

                return false;

            }

        }

        return true;

    }
    
}

