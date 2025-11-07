using System;
class Breathing : Activity
{
    public Breathing()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");  
    }

    public void BreathDisplay(Activity activity)
    {
        int timer = GetTime();
        int currentTime = 0;

        Console.WriteLine("Get ready...");
        activity.Animation(3);
        Console.Clear();

        while (currentTime < timer)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            activity.Animation(5);
            Console.WriteLine("Breathe out...");
            activity.Animation(5);
            currentTime += 10;

        }

    }

    
}