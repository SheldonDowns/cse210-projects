using System;
using System.Collections.Generic;
using System.IO;

public class Entry
{
    private string filePath;
    private List<string> entries;

    public Entry(string filePath)
    {
        this.filePath = filePath;
        entries = new List<string>();
    }

    public void AddEntry(string prompt)
    {
        Console.WriteLine($"Journal Prompt: {prompt}");
        Console.WriteLine("Please write your journal entry:");
        string entry = Console.ReadLine();

        entries.Add($"Entry Date: {DateTime.Now}\nPrompt: {prompt}\n{entry}\n{new string('-', 50)}");
        Console.WriteLine("Your journal entry has been added but not yet saved to the file.");
    }

    public void SaveEntriesToFile()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                foreach (string entry in entries)
                {
                    writer.WriteLine(entry);
                }
            }

            Console.WriteLine("Your journal entries have been saved to the file.");
            entries.Clear(); // Clear the entries after saving
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the entries: {ex.Message}");
        }
    }

    public void LoadEntries()
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the entries: {ex.Message}");
        }
    }

    public void ShowUnsavedEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No unsaved entries to display.");
        }
        else
        {
            Console.WriteLine("Unsaved Entries:");
            foreach (string entry in entries)
            {
                Console.WriteLine(entry);
            }
        }
    }
}
