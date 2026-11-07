public class Enemy : Character
{
    public int GoldReward { get; set; }
    public int Damage { get; set; }

    public Enemy(string name, int health, int level, int goldReward, int damage) : base(name, health, level)
    {
        GoldReward = goldReward;
        Damage = damage;
    }

    public override void Attack(Character target)
    {
        
    }
}