public class Rogue : Player
{
    public int Stealth { get; set; }

    public Rogue(string name)
        : base(name, 200, 1, 0)
    {
        Stealth = 50;
    }

    public int Backstab()
    {
        if (Stealth < 10)
        {
            return 0;
        }
        else
        {
            Stealth -= 10;
            int damage = 30;
            return damage;
        }
    }
    public override int GetCritChance()
    {
        return 30; // Rogue has a higher critical hit chance of 30%
    }
}