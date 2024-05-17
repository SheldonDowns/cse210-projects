using System;
using System.Collections.Generic;
using System.IO;

public class PromptSelector
{
    private string[] prompts;
    private Random rand;

    public PromptSelector()
    {
        // Hard-coded list of prompts
        prompts = new string[]
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

    public string GetRandomPrompt()
    {
        int index = rand.Next(prompts.Length);
        return prompts[index];
    }
}
