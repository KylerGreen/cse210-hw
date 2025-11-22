using System;

class Checklist : Goal
{
    private int _timeCompleted = 0;

    private int _maxCompleted = 0;

    private int _bonusPoints = 0;


    public Checklist(int points, string name, string description, int timesToComplete, int bonusPoints, bool status) : base(points, name, description, status)
    {
        _maxCompleted = timesToComplete;
        _bonusPoints = bonusPoints;
    }

    public override void UpdateStatus(Menu menu)
    {
        _timeCompleted += 1;
        menu.AddPoints(GetPoints());
        if (_timeCompleted >= _maxCompleted)
        {
            menu.AddPoints(_bonusPoints);
        }
    }
    
    public override void DisplayGoal()
    {
        string _name = GetName();
        string _description = GetDescription();
        string status =  GetStatus();
        Console.WriteLine($"{status} {_name} ({_description}) -- Currently completed: {_timeCompleted}/{_maxCompleted}");

    }

    public override string GetStringRepresentation(Goal goal)
    {
        return $"Checklist:{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetStatus()}|{_timeCompleted}|{_maxCompleted}|{_bonusPoints}";
    }
}