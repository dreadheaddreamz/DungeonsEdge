public class GoblinGuardian : Enemy
{
    public GoblinGuardian(string name)
        : base(name, health: 600, level: 1, goldReward: 30, expReward: 15, damage: 20)
    {
    }
    public void ShieldCrush(Character target)
    {
        int bashDamage = 25;
        Console.WriteLine($"{Name} performs a shield bash on {target.Name} for {bashDamage} damage!");
        target.TakeDamage(bashDamage);
    }

    public override void Attack(Character target)
    {
        ShieldCrush(target);
    }
}