using System;

class Eternal : Goal
{

    public Eternal(int points, string name, string description, bool status) : base(points, name, description, status)
    {

    }

    public override void UpdateStatus(Menu menu)
    {
        menu.AddPoints(GetPoints());
    }
    
    public override void DisplayGoal()
    {
        string _name = GetName();
        string _description = GetDescription();
        string status = "[ ]";
        Console.WriteLine($"{status} {_name} ({_description})");

    }

    public override string GetStringRepresentation(Goal goal)
    {
        return $"Eternal:{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetStatus()}";
    }
}