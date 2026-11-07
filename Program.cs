public class Program
{
    public static void Main(string[] args)
    {
        Player player = new Player ("James", 200, 30, 50);
        Console.WriteLine($"Player Name: {player.Name}");
        Console.WriteLine($"Player Health: {player.Health}");
        Console.WriteLine($"Player Level: {player.Level}");
        Console.WriteLine($"Player Gold: {player.Gold}");

        player.TakeDamage(50);
        Console.WriteLine($"Player Health after taking damage: {player.Health}");

        Tank tank = new Tank("Arnold", 300, 25, 150, 20);
        Console.WriteLine($"Tank Name: {tank.Name}");
        Console.WriteLine($"Tank Health: {tank.Health}");
        Console.WriteLine($"Tank Level: {tank.Level}");
        Console.WriteLine($"Tank Gold: {tank.Gold}");
        Console.WriteLine($"Tank Armor: {tank.Armor}");

        int damageDealt = tank.ShieldBash();
        Console.WriteLine($"Damage dealt by Shield Bash: {damageDealt}");

        tank.TakeDamage(100);
        Console.WriteLine($"Tank Health after taking damage: {tank.Health}");
    }
}
