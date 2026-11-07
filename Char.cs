public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Level { get; set; }

    public Character(string name, int health, int level)
    {
        Name = name;
        Health = health;
        Level = level;
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

    public virtual void Attack(Character target)
    {

    }
}