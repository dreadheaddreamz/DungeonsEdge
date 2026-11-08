public class Enemy : Character
{
    public int GoldReward { get; set; }
    public int Damage { get; set; }
    public int ExperienceReward { get; set; }

    public Enemy(string name, int health, int level, int goldReward, int expReward, int damage) : base(name, health, level)
    {
        GoldReward = goldReward;
        ExperienceReward = expReward;
        Damage = damage;
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} attacks {target.Name} for {Damage} damage!");

        target.TakeDamage(Damage);

    }
}