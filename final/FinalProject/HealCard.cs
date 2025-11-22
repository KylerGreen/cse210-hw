using System;

class HealCard : Card
{
    private int _healing = 0;


    public HealCard(string name, string type, int cost, string description, int healing) : base(name, type, cost, description)
    {
        _healing = healing;
    }

    public int Heal()
    {
        return _healing;
    }

    public override void HealthEffect(Player player, Enemy enemy, int effectAmount)
    {
        player.Heal(effectAmount);
    }
}