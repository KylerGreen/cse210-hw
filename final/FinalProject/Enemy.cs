using System;

class Enemy
{
    private int _health = 50;

    private int _damage = 10;

    private int _defense = 0;


    public Enemy(int health, int damage)
    {
        _health = health;

        _damage = damage;
    }

    public void DisplayStatus()
    {
        Console.WriteLine($"Enemy Health: {_health}");
    }

    public int Attack()
    {
        return _damage;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
}