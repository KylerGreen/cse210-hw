using System;

class Card
{

    public string _name = "";

    public string _type = "";

    public int _cost = 0;

    public string _description = ""; 


    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Type: {_type} | Cost: {_cost}");
        Console.WriteLine($"Description: {_description}");
    }
}