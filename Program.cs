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

        Tank tank = new Tank("Arnold");
        Console.WriteLine($"Tank Name: {tank.Name}");
        Console.WriteLine($"Tank Health: {tank.Health}");
        Console.WriteLine($"Tank Level: {tank.Level}");
        Console.WriteLine($"Tank Gold: {tank.Gold}");
        Console.WriteLine($"Tank Armor: {tank.Armor}");

        int damageDealt = tank.ShieldBash();
        Console.WriteLine($"Damage dealt by Shield Bash: {damageDealt}");

        tank.TakeDamage(100);
        Console.WriteLine($"Tank Health after taking damage: {tank.Health}");

        Mage mage = new Mage("Gandalf");
        Console.WriteLine($"Mage Name: {mage.Name}");
        Console.WriteLine($"Mage Health: {mage.Health}");
        Console.WriteLine($"Mage Level: {mage.Level}");
        Console.WriteLine($"Mage Gold: {mage.Gold}");
        Console.WriteLine($"Mage Mana: {mage.Mana}");

        int fireballDamage = mage.Fireball();
        Console.WriteLine($"Damage dealt by Fireball: {fireballDamage}");
        Console.WriteLine($"Mage Mana after casting Fireball: {mage.Mana}");

        Rogue rogue = new Rogue("Shadow");
        Console.WriteLine($"Rogue Name: {rogue.Name}");
        Console.WriteLine($"Rogue Health: {rogue.Health}");
        Console.WriteLine($"Rogue Level: {rogue.Level}");
        Console.WriteLine($"Rogue Gold: {rogue.Gold}");
        Console.WriteLine($"Rogue Stealth: {rogue.Stealth}");

        int backstabDamage = rogue.Backstab();
        Console.WriteLine($"Damage dealt by Backstab: {backstabDamage}");
        Console.WriteLine($"Rogue Stealth after casting Backstab: {rogue.Stealth}");
    }
}
