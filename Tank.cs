public class Tank : Player
{
    public int Armor { get; set; }

    public Tank(string name)
        : base(name, maxHealth: 300, level: 1, gold: 0)
    {
        Armor = 100;
    }

    public int ShieldBash()
    {
        int damage = 20;
        return damage;
    }

    public override void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            return;
        }
        int effectiveDamage = damage - Armor;
        if (effectiveDamage < 0)
        {
            effectiveDamage = 0;
        }
        Health -= effectiveDamage;
        if (Health <= 0)
        {
            Health = 0;
        }
    }
}