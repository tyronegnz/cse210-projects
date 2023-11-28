using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            ScriptureReference reference = new ScriptureReference("John 3:16");
            Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            int wordsToHide = 3; // Define the number of words to hide

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Scripture: {scripture.Reference.Reference}");
                Console.WriteLine(scripture.GetVisibleText());
                Console.WriteLine("\nPress Enter to reveal more or type 'quit' to exit...");

                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                    break;

                scripture.HideRandomWords(wordsToHide); // Hide 'wordsToHide' number of words
                if (scripture.AllWordsHidden())
                    break;
            }
        }
    }
}
