public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== DUNGEONS EDGE ===");

        Tank tank = new Tank("James");
        Mage mage = new Mage("Gandalf");
        Rogue rogue = new Rogue("Shadow");

        TestTank(tank);
        TestMage(mage);
        TestRogue(rogue);

        Console.WriteLine("\n\n=== COMBAT TESTING ===");

        TestEnemyAttack();

        TestCombat(tank);
        TestCombat(mage);
        TestCombat(rogue);

        TestGoblinGuardian(tank);
        TestGoblinGuardian(mage);
        TestGoblinGuardian(rogue);
    }

    public static void TestTank(Tank tank)
    {
        tank.Level = 30;

        Console.WriteLine("\n--- TANK ---");
        Console.WriteLine($"Name: {tank.Name}");
        Console.WriteLine($"Health: {tank.Health}");
        Console.WriteLine($"Level: {tank.Level}");
        Console.WriteLine($"Gold: {tank.Gold}");
        Console.WriteLine($"Armor: {tank.Armor}");
        Console.WriteLine($"Critical Chance: {tank.GetCritChance()}%");
        Console.WriteLine($"Shield Bash Damage: {tank.ShieldBash()}");
        Console.WriteLine($"Health after damage: {tank.Health}");
    }

    public static void TestMage(Mage mage)
    {
        Console.WriteLine("\n--- MAGE ---");
        Console.WriteLine($"Name: {mage.Name}");
        Console.WriteLine($"Health: {mage.Health}");
        Console.WriteLine($"Level: {mage.Level}");
        Console.WriteLine($"Gold: {mage.Gold}");
        Console.WriteLine($"Mana: {mage.Mana}");
        Console.WriteLine($"Critical Chance: {mage.GetCritChance()}%");
        Console.WriteLine($"Fireball Damage: {mage.Fireball()}");
        Console.WriteLine($"Mana after Fireball: {mage.Mana}");
    }

    public static void TestRogue(Rogue rogue)
    {
        Console.WriteLine("\n--- ROGUE ---");
        Console.WriteLine($"Name: {rogue.Name}");
        Console.WriteLine($"Health: {rogue.Health}");
        Console.WriteLine($"Level: {rogue.Level}");
        Console.WriteLine($"Gold: {rogue.Gold}");
        Console.WriteLine($"Stealth: {rogue.Stealth}");
        Console.WriteLine($"Critical Chance: {rogue.GetCritChance()}%");
        Console.WriteLine($"Backstab Damage: {rogue.Backstab()}");
        Console.WriteLine($"Stealth after Backstab: {rogue.Stealth}");
    }

    public static void TestEnemyAttack()
    {
        Player player = new Player("James", 200, 30, 50);
        Enemy enemy = new Enemy("Goblin", 100, 1, 15, 25, 10);

        Console.WriteLine($"\nPlayer Health: {player.Health}");

        enemy.Attack(player);

        Console.WriteLine($"Player Health After Attack: {player.Health}");
    }

    public static void TestCombat(Player player)
    {
        Console.WriteLine($"\n--- {player.Name} VS MALAZAR ---");

        GoblinNecromancer necro = new GoblinNecromancer("Malazar");

        Combat combat = new Combat(player, necro);

        combat.StartCombat();

        Console.WriteLine("\n--- COMBAT RESULTS ---");
        Console.WriteLine($"Player Health: {player.Health}");
        Console.WriteLine($"Necromancer Health: {necro.Health}");
        Console.WriteLine($"Necromancer Mana: {necro.Mana}");

        if (necro.Health > 0)
        {
            necro.SoulSteal(player);

            Console.WriteLine($"Player Health: {player.Health}");
            Console.WriteLine($"Necromancer Health: {necro.Health}");
            Console.WriteLine($"Necromancer Mana: {necro.Mana}");
        }
        else
        {
            Console.WriteLine($"{necro.Name} cannot cast spells because he has been defeated.");
        }
    }

    public static void TestGoblinGuardian(Player player)
    {
        Console.WriteLine($"\n--- {player.Name} VS GOBLIN GUARDIAN ---");

        GoblinGuardian guardian = new GoblinGuardian("Gorath");

        Console.WriteLine($"Guardian Health: {guardian.Health}");
        Console.WriteLine($"Guardian Damage: {guardian.Damage}");

        Combat combat = new Combat(player, guardian);

        combat.StartCombat();

        Console.WriteLine("\n--- COMBAT RESULTS ---");
        Console.WriteLine($"Player Health: {player.Health}");
        Console.WriteLine($"Guardian Health: {guardian.Health}");
    }
}