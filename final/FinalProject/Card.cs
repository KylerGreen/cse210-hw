using System;

class Card
{

    private string _name = "";

    private string _type = "";

    private int _cost = 0;

    private string _description = "";


    public Card(string name, string type, int cost, string description)
    {
        _name = name;

        _type = type;

        _cost = cost;

        _description = description;
    }

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Type: {_type} | Cost: {_cost}");
        Console.WriteLine($"Description: {_description}");
    }


    public virtual void HealthEffect(Player player, Enemy enemy, int effectAmount)
    {
        enemy.TakeDamage(effectAmount);
    }
    

}