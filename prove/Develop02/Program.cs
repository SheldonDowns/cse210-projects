using System;
using System.Collections.Generic;
using System.IO;

using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Ask the user for the filename where the journal entries will be saved
        Console.WriteLine("Please enter the filename to save your journal entries:");
        string fileName = Console.ReadLine();

        // Ensure the filename is not empty or null
        if (string.IsNullOrWhiteSpace(fileName))
        {
            // Creates file using defalt name
            Console.WriteLine("Filename cannot be empty. Using default filename 'journal.txt'.");
            fileName = "journal.txt";
        }

        // Create an instance of the JournalApp class with the provided filename
        JournalApp journalApp = new JournalApp(fileName);

        // Run the journal application
        journalApp.Run();
    }
}
