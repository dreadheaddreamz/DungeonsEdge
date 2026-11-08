
using System;
using System.Diagnostics.Tracing;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== DUNGEONS EDGE ===\n");

        Tank tank = TestTank();
        Mage mage = TestMage();
        Rogue rogue = TestRogue();

        Console.WriteLine("\n=== COMBAT TESTING ===");

        TestEnemyAttack();
        TestCombat(tank);
        TestCombat(mage);
        TestCombat(rogue);
    }

    public static Tank TestTank()
    {
        Console.WriteLine("--- TANK ---");

        Tank tank = new Tank("James");
        tank.Level = 30;

        Console.WriteLine($"Name: {tank.Name}");
        Console.WriteLine($"Health: {tank.Health}");
        Console.WriteLine($"Level: {tank.Level}");
        Console.WriteLine($"Gold: {tank.Gold}");
        Console.WriteLine($"Armor: {tank.Armor}");
        Console.WriteLine($"Critical Chance: {tank.GetCritChance()}%");

        int damage = tank.ShieldBash();

        Console.WriteLine($"Shield Bash Damage: {damage}");

        tank.TakeDamage(100);

        Console.WriteLine($"Health after damage: {tank.Health}\n");

        return tank;
    }

    public static Mage TestMage()
    {
        Console.WriteLine("--- MAGE ---");

        Mage mage = new Mage("Gandalf");
        mage.Level = 20;

        Console.WriteLine($"Name: {mage.Name}");
        Console.WriteLine($"Health: {mage.Health}");
        Console.WriteLine($"Level: {mage.Level}");
        Console.WriteLine($"Gold: {mage.Gold}");
        Console.WriteLine($"Mana: {mage.Mana}");
        Console.WriteLine($"Critical Chance: {mage.GetCritChance()}%");

        int damage = mage.Fireball();

        Console.WriteLine($"Fireball Damage: {damage}");
        Console.WriteLine($"Mana after Fireball: {mage.Mana}\n");

        return mage;
    }

    public static Rogue TestRogue()
    {
        Console.WriteLine("--- ROGUE ---");

        Rogue rogue = new Rogue("Shadow");
        rogue.Level = 25;

        Console.WriteLine($"Name: {rogue.Name}");
        Console.WriteLine($"Health: {rogue.Health}");
        Console.WriteLine($"Level: {rogue.Level}");
        Console.WriteLine($"Gold: {rogue.Gold}");
        Console.WriteLine($"Stealth: {rogue.Stealth}");
        Console.WriteLine($"Critical Chance: {rogue.GetCritChance()}%");

        int damage = rogue.Backstab();

        Console.WriteLine($"Backstab Damage: {damage}");
        Console.WriteLine($"Stealth after Backstab: {rogue.Stealth}\n");

        return rogue;
    }

    public static void TestCombat(Player player)
    {
        Console.WriteLine($"\n--- {player.Name} VS GOBLIN ---");

        Enemy enemy = new Enemy("Goblin", 100, 1, 15, 10, 20);

        Combat combat = new Combat(player, enemy);

        combat.StartCombat();

        Console.WriteLine(
            $"{player.Name} Health Remaining: {player.Health}"
        );

        Console.WriteLine(
            $"{enemy.Name} Health Remaining: {enemy.Health}"
        );
    }
    public static void TestEnemyAttack()
    {
        Player player = new Player("James", 200, 30, 50);
        Enemy enemy = new Enemy("Goblin", 100, 1, 15, 10, 20);

        Console.WriteLine($"Player Health: {player.Health}");

        enemy.Attack(player);

        Console.WriteLine($"Player Health After Attack: {player.Health}");
    }
}
