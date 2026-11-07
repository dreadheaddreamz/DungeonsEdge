using System;

public class Player
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int MaxHealth { get; set; }
    public int Level { get; set; }
    public int Gold { get; set; }

    public Player(string name, int maxHealth, int level, int gold)
    {
        Name = name;
        MaxHealth = maxHealth;
        Health = maxHealth;
        Level = level;
        Gold = gold;
    }

    public virtual void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            return;
        }
        Health -= damage;
        if (Health <= 0)
        {
            Health = 0;
        }
    }
}