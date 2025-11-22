using System;

class Player
{
    private int _health = 100;

    private int _pip = 2;

    private Deck _deck = new Deck();


    public Player(int health, int pip)
    {
        _health = health;

        _pip = pip;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Player Health: {_health} | Pips: {_pip}");
    }

    public void Heal(int healing)
    {
        _health += healing;
    }

    public bool UsePips(int cost)
    {
        if (_pip >= cost)
        {
            _pip -= cost;

            return true;
        }
        else
        {
            return false;
        }
    }


}