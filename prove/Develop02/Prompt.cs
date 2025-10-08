using System;

class Prompt
{ 
    public string GeneratePrompt()
    {
        string[] prompts = {
            "What was the best part of my day?",
            "What am I grateful for today?",
            "What is one thing I learned today?",
            "How did I overcome a challenge today?",
            "What made me smile today?"
        };

        Random random = new Random();
        int index = random.Next(prompts.Length);
        return prompts[index];
    }
}