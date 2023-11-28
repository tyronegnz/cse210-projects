using System;
using System.Collections.Generic;
using System.Linq;

namespace Develop03
{
    // Represents a scripture containing words and methods to manipulate them
    public class Scripture
    {
        public ScriptureReference Reference { get; private set; } // Reference of the scripture
        public List<Word> Words { get; private set; } // List of words in the scripture

        public Scripture(ScriptureReference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        // Hide a random words in the scripture
        public void HideRandomWords(int countToHide)
        {
            Random random = new Random();
            var visibleWords = Words.Where(word => !word.IsHidden).ToList();
            if (visibleWords.Count == 0) return;

            int wordsHidden = 0;
            while (wordsHidden < countToHide)
            {
                int indexToHide = random.Next(0, Words.Count);
                if (!Words[indexToHide].IsHidden)
                {
                    Words[indexToHide].IsHidden = true;
                    wordsHidden++;
                }
            }
        }

        // Check if all words in the scripture are hidden
        public bool AllWordsHidden()
        {
            return Words.All(word => word.IsHidden);
        }

        // Get the scripture text with hidden words replaced by underscores
        public string GetVisibleText()
        {
            return string.Join(" ", Words.Select(word => word.IsHidden ? "___" : word.Text));
        }
    }
}