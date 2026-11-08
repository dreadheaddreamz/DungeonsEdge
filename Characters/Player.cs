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

    public virtual int GetCritChance()
    {
        return 20; // Base critical hit chance of 10%
    }

    public override void Attack(Character target)
    {
        Random random = new Random();

        int damage = Level * 5; // Example damage calculation based on player level

        bool isCritiical = Random.Shared.Next(1, 101) <= GetCritChance();

        if (isCritiical)
        {
            damage *= 2; // Double damage for critical hits
            Console.WriteLine("Critical hit!");
        }

        Console.WriteLine($"{Name} attacks {target.Name} for {damage} damage!");
        
        target.TakeDamage(damage);
    }
}