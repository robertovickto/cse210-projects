using System;

public class PromptGenerator

{

    // Attributes

    List<string> _prompts = new List<string>()

    {

        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "How was today different from yesterday?",
        "What did I do today that made me feel better about myself?",
        "If I could've spent today with anyone in the world, who would it be? Why?",
        "What song, movie, or any other piece of art could describe my day today? Why?",
        "What gave me a reason to smile today? If nothing, Why?",
        "What testimony do I have after living to see the end of today?"

    };

    Random _randomPrompt = new Random();

    // Method

    public string GetRandomPrompt()

    {

        int Index = _randomPrompt.Next(_prompts.Count);

        return _prompts[Index];

    }
    
}