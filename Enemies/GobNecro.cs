public class GoblinNecromancer : Enemy
{
    public int Mana { get; set; }
    public GoblinNecromancer(string name)
        : base(name, health: 120, level: 1, goldReward: 20, expReward: 10, damage: 15)
    {
        Mana = 100;
    }
    public void SoulSteal(Character target)
    {
        if (Mana < 20)
        {
            Console.WriteLine($"{Name} does not have enough mana to cast a spell.");
            return;
        }

        Mana -= 20;
        int spellDamage = 35;
         Health += spellDamage / 2; // Goblin Necromancer heals for half the damage dealt
        Console.WriteLine($"{Name} casts a spell on {target.Name} for {spellDamage} damage!");
        target.TakeDamage(spellDamage);
    }
}