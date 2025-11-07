using System;

class Listing : Activity
{
    private int _count;

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public Listing()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void ListingDisplay(Activity activity)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTime());
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine(RandPrompt());
        Console.WriteLine();
        Console.WriteLine("You may begin in:");
        activity.Animation(5);
        Console.Clear();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            _count += 1;
        }

        Console.WriteLine($"You listed {_count} items!");

    }
    
    public string RandPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];

    }


}