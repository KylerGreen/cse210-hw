using System;

class Menu
{
    public void Display()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine("   1. Start breathing activity");
        Console.WriteLine("   2. Start reflecting activity");
        Console.WriteLine("   3. Start listing activity");
        Console.WriteLine("   4. Quit");
        Console.Write("Select a choice from the Menu: ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Breath();
        }
        else if (choice == "2")
        {
            Reflect();
        }
        else if (choice == "3")
        {
            List();
        }
        else if (choice == "4")
        {
            Quit();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please enter a valid option");
            Display();
        }
        
    }
    public void Breath()
    {
        Breathing activity = new Breathing();
        activity.SetAnimation();
        activity.Animation(3);
        activity.Display();
        activity.BreathDisplay(activity);
        activity.DisplayFinish();
        activity.Animation(3);
        Console.Clear();
        Display();
    }

    public void Reflect()
    {
        Reflection activity = new Reflection();
        activity.SetAnimation();
        activity.Animation(3);
        activity.Display();
        activity.ReflectDisplay(activity);
        activity.DisplayFinish();
        activity.Animation(3);
        Console.Clear();
        Display();

    }

    public void List()
    {
        Listing activity = new Listing();
        activity.SetAnimation();
        activity.Animation(3);
        activity.Display();
        activity.ListingDisplay(activity);
        activity.DisplayFinish();
        activity.Animation(3);
        Console.Clear();
        Display();

    }

    public void Quit()
    {

        Console.Clear();
    }

}