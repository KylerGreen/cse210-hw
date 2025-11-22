using System;

class BlockCard : Card
{
    private int _blocking = 0;


    public BlockCard(string name, string type, int cost, string description, int blocking) : base(name, type, cost, description)
    {
        _blocking = blocking;
    }

    public int Block()
    {
        return _blocking;
    }
}