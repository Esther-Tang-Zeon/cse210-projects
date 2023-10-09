using System;
using System.IO;
using System.Collections.Generic;

public class JournalCollection 
{
    // A list of JournalEntry objects 
    // Display the journal 
    // Save the journal to a file
    // Load the journal from a file

    public List<JournalEntry> _entries = new List<JournalEntry>(); 

    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }

    public void Display()
    {
        Console.WriteLine("Entries:");
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename) 
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear();

        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string[] parts = reader.ReadLine().Split('|');
                if (parts.Length < 3) continue; 
                JournalEntry entry = new JournalEntry(parts[1], parts[2]);
                entry._date = parts[0];
                _entries.Add(entry);
            }
        }
    }
}