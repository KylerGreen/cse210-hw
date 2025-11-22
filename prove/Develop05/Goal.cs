using System;

class Goal
{
    private int _points = 0;

    private string _name = "";

    private string _description = "";

    private bool _status = false;


    public Goal(int points, string name, string description, bool status)
    {
        _points = points;
        _name = name;
        _description = description;
        _status = status;
    }

    public virtual void UpdateStatus(Menu menu)
    {
        _status = true;
        menu.AddPoints(GetPoints());
    }

    public virtual void DisplayGoal()
    {
        string status = GetStatus();
        Console.WriteLine($"{status} {_name} ({_description})");
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetStatus()
    {
        return _status ? "[X]" : "[ ]";
    }

    public int GetPoints()
    {
        return _points;
    }

    public virtual string GetStringRepresentation(Goal goal)
    {
        return $"{_name}|{_description}|{_points}|{_status}";
    }
}