using System;
using System.Collections.Generic;
using System.IO;

public class PromptSelector
{
    private List<string> prompts;
    private Random rand;

    // Constructor initializes the prompts list and the Random instance
    public PromptSelector()
    {
        // Hard-coded list of prompts
        prompts = new List<string>
        {
            "What's your favorite color?",
            "Tell me about your last vacation.",
            "What's the capital of France?",
            "Describe your perfect day.",
            "What are you grateful for today?",
            "What's your biggest dream?",
            "What are some of your favorite books?",
            "Describe a challenging moment you faced and how you overcame it.",
            "What is your happiest memory?",
            "Where do you see yourself in five years?"
            // Add more prompts here if needed
        };

        rand = new Random();
    }

    // Method to get a random prompt from the list
    public string GetRandomPrompt()
    {
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}

public class Entry
{
    private string filePath;
    private List<string> entries;

    // Constructor to set the file path
    public Entry(string filePath)
    {
        this.filePath = filePath;
        entries = new List<string>();
    }

    // Method to prompt the user for a journal entry
    public void AddEntry(string prompt)
    {
        Console.WriteLine($"Journal Prompt: {prompt}");
        Console.WriteLine("Please write your journal entry:");
        string entry = Console.ReadLine();

        entries.Add($"Entry Date: {DateTime.Now}\nPrompt: {prompt}\n{entry}\n{new string('-', 50)}");
        Console.WriteLine("Your journal entry has been added but not yet saved to the file.");
    }

    // Method to save the journal entries to a file
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

    // Method to load and display all entries from the file
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

    // Method to show entries before they are saved to the file
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

public class Journal
{
    private Entry entry;
    private PromptSelector promptSelector;

    public Journal(string filePath)
    {
        entry = new Entry(filePath);
        promptSelector = new PromptSelector();
    }

    // Method to display the menu and handle user choices
    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Add a journal entry");
            Console.WriteLine("2. Load entries from the file");
            Console.WriteLine("3. Show unsaved entries");
            Console.WriteLine("4. Save entries to the file");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    string prompt = promptSelector.GetRandomPrompt();
                    entry.AddEntry(prompt);
                    break;
                case "2":
                    entry.LoadEntries();
                    break;
                case "3":
                    entry.ShowUnsavedEntries();
                    break;
                case "4":
                    entry.SaveEntriesToFile();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    public static void Main()
    {
        // Ask the user for the filename where the journal entries will be saved
        Console.WriteLine("Please enter the filename to save your journal entries:");
        string fileName = Console.ReadLine();

        // Ensure the filename is not empty or null
        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("Filename cannot be empty. Using default filename 'journal.txt'.");
            fileName = "journal.txt";
        }

        // Create an instance of the Journal class with the provided filename
        Journal journal = new Journal(fileName);

        // Display the menu to the user
        journal.DisplayMenu();
    }
}
