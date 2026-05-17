using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class PromptGenerator
{
   public List<string>  _prompts = new List<string>()
   {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day",
        "How did I see the hand of God in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What have learned from the Book of Mormon today?",
   };

   public PromptGenerator()
   {
        
    }

   public string GetRandomPrompt()
    {
        Random number = new Random ();

        int index = number.Next(_prompts.Count);
        return _prompts[index];
    }
}