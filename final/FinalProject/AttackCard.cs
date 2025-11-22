using System;

class AttackCard : Card
{
    private int _damage = 0;


    public AttackCard(string name, string type, int cost, string description, int damage) : base(name, type, cost, description)
    {
        _damage = damage;
    }

    public int Attack()
    {
        return _damage;
    }
}