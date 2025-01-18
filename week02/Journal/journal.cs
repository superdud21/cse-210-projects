using System;
using System.Formats.Asn1;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string date, string mood, string energy, string prompt, string newEntry)
    {
        _entries.Add(new Entry {_date = date, _mood = mood, _energy = energy, _promptText = prompt, _entryText = newEntry});
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("Enter a filepath: ");
        string filename = Console.ReadLine();
        Console.WriteLine("\n");

        using (StreamWriter journalFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                journalFile.WriteLine($"{entry._date}|{entry._mood}|{entry._energy}|{entry._promptText}|{entry._entryText}");
            }
        }

    }

    public void LoadFromFile()
    {
        Console.WriteLine("Enter a filepath: ");
        string filename = Console.ReadLine();
        Console.WriteLine("\n");

        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] entries = File.ReadAllLines(filename);
            foreach (string entry in entries)
            {
                string[] parts = entry.Split('|');
                _entries.Add(new Entry {_date = parts[0], _mood = parts[1], _energy = parts[2], _promptText = parts[3], _entryText = parts[4]});
            }

        } else {
            Console.WriteLine($"No Journal File exists at: {filename}");
        }
    }
}