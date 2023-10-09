using System;
public class JournalEntry
{
    // This should store the prompt, the user's response, and the date. 
    public string _prompt;
    public string _response;
    public string _date; 

    public JournalEntry (string prompt, string response) 
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public void Display() 
    { 
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");
        Console.WriteLine(); 
    }

}