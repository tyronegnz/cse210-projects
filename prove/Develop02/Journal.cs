using System;
using System.Collections.Generic;

namespace Develop02
{
    public class Journal
    {
        // List to store journal entries
        private List<JournalEntry> entries = new List<JournalEntry>();

        // Method to add a new entry to the journal
        public void AddEntry(JournalEntry entry)
        {
            entries.Add(entry);
        }

        // Method to display all entries in the journal
        public void DisplayEntries()
        {
            Console.Clear();
            Console.WriteLine("Journal Entries:");

            if (entries.Count == 0)
            {
                Console.WriteLine("No entries yet.\n");
                return;
            }

            foreach (var entry in entries)
            {
                Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}\n");
            }
        }

        // Method to retrieve all entries in the journal
        public List<JournalEntry> GetAllEntries()
        {
            return entries;
        }
    }
    // Current date and time.
    public class JournalEntry
    {
        public DateTime Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }
    }
}