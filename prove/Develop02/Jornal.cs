

public class JournalApp
{
    private Entry entry;
    private PromptSelector promptSelector;

    public JournalApp(string filePath)
    {
        entry = new Entry(filePath);
        promptSelector = new PromptSelector();
    }


    // Creates a while loop and displays the jornal menu
    public void Run()
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
}
