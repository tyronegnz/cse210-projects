using System;
using Develop02;
using System.Collections.Generic;
using System.IO;
class Program
{
    // Create a new Journal instance
    static Journal journal = new Journal();

    static void Main()
    {
        //Display and loop through options
        bool exit = false;

        do
        {
            Console.WriteLine("\nWelcome to the journal program!\nPlease select one of the following options:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        WriteNewEntry();
                        break;
                    case 2:
                        DisplayJournal();
                        break;
                    case 3:
                        SaveToFile();
                        break;
                    case 4:
                        LoadFromFile();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a number between 1 and 5.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }

        } while (!exit);
    }

    static void WriteNewEntry()
    {
        Console.Clear();
        Console.WriteLine("Write a new entry:");

        string prompt = PromptGenerator.GetRandomPrompt();

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };

        journal.AddEntry(entry);

        Console.WriteLine("Entry saved successfully!\n");
    }

    static void DisplayJournal()
    {
        journal.DisplayEntries();
    }

    static void SaveToFile()
    {
        Console.Clear();
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        try
        {
            List<JournalEntry> entries = journal.GetAllEntries();

            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
                }
            }

            Console.WriteLine("Journal saved to file successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving to file: {ex.Message}\n");
        }
    }

    static void LoadFromFile()
    {
        Console.Clear();
        Console.Write("Enter the filename to load the journal: ");
        string filename = Console.ReadLine();

        try
        {
            List<JournalEntry> loadedEntries = new List<JournalEntry>();

            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 3 &&
                        DateTime.TryParse(parts[0], out DateTime date) &&
                        !string.IsNullOrEmpty(parts[1]) &&
                        !string.IsNullOrEmpty(parts[2]))
                    {
                        JournalEntry entry = new JournalEntry
                        {
                            Date = date,
                            Prompt = parts[1],
                            Response = parts[2]
                        };

                        loadedEntries.Add(entry);
                    }
                }
            }

            // Create a new Journal instance
            journal = new Journal();
            foreach (var entry in loadedEntries)
            {
                journal.AddEntry(entry);
            }

            Console.WriteLine("Journal loaded from file successfully!\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading from file: {ex.Message}\n");
        }
    }
}