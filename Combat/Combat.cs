public class Combat
{
    public Player Player { get; private set; }
    public Enemy Enemy { get; private set; }

    public Combat(Player player, Enemy enemy)
    {
        Player = player;
        Enemy = enemy;
    }
    public void StartCombat() {
        while (Player.Health > 0 && Enemy.Health > 0)
        {
            Player.Attack(Enemy);
            if (Enemy.Health <= 0)
            {
                Console.WriteLine($"{Enemy.Name} has been defeated!");
                break;
            }

            Enemy.Attack(Player);
            if (Player.Health <= 0)
            {
                Console.WriteLine($"{Player.Name} has been defeated!");
                break;
            }
        }
    }
}