using System;

public class Player : Character
{
    public int MaxHealth { get; set; }

    public int Gold { get; set; }

    public Player(string name, int maxHealth, int level, int gold) : base(name, maxHealth, level)
    {
        MaxHealth = maxHealth;
        Gold = gold;
    }

    public override void Attack(Character target)
    {

    }
}