public class Mage : Player
{
    public int Mana { get; set; }

    public Mage(string name)
        : base(name, 200, 1, 0)
    {
        Mana = 100;
    }
    public int Fireball()
    {
        if (Mana < 15)
        {
            return 0;
        }
        else
        {
            Mana -= 15;
            int damage = 40;
            return damage;
        }
    }
    public override int GetCritChance()
    {
        return 30; // Mage has a higher critical hit chance of 30%
    }
}