using System;

namespace Develop02
{
    public class PromptGenerator
    {
        //Array containing different prompts.
        private static readonly string[] prompts = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

        //Method to get a random prompt from the array.
        public static string GetRandomPrompt()
        {
            Random rnd = new Random();
            int index = rnd.Next(prompts.Length);
            return prompts[index];
        }
    }
}