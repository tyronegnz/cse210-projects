using System;

namespace Develop03
{
    public class Word
    {
        public string Text { get; set; } // The text of the word
        public bool IsHidden { get; set; } // Indicates if the word is hidden

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }
    }
}
