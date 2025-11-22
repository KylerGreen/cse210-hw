using System;

class Simple : Goal
{

    public Simple(int points, string name, string description, bool status) : base(points, name, description, status)
    {
        
    }

    public override string GetStringRepresentation(Goal goal)
    {
        return $"Simple:{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetStatus()}";
    }
    
}