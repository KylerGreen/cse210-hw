using System;

class Activity
{
    private string _name;

    private string _description;

    private int _time;

    private List<string> _animation = new List<string>();


    public void Display()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        int time = int.Parse(Console.ReadLine());
        SetTime(time);

    }

    public void DisplayFinish()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_time} seconds of the {_name}.");
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetTime(int time)
    {
        _time = time;
    }

    public void SetAnimation()
    {
        _animation.Add("|");
        _animation.Add("/");
        _animation.Add("-");
        _animation.Add("\\");
        _animation.Add("|");
        _animation.Add("/");
        _animation.Add("-");
        _animation.Add("\\");
    }

    public int GetTime()
    {
        return _time;
    }

    public void Animation(int time)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        Console.CursorVisible = false;
        while (DateTime.Now < endTime)
        {
            foreach (string s in _animation)
            {
                Console.Write(s);
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
        }
        Console.CursorVisible = true;
        
    }
}