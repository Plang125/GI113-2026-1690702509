namespace Lab07
{
/*
* Student ID : 1690702509
* Name       : Rathaphol Chaowlumbua
* Section    : 129C
* No.        : 15
* Course     : GI113 Computer Programming (GI)
*/
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part A

            const int MonsterHp = 10;

            Console.Write("Monster Defense: ");
            int.TryParse(Console.ReadLine(), out int monsterDefense);
            Console.WriteLine($"A Slime appears! HP {MonsterHp}, DEF {monsterDefense}");

            Console.WriteLine("=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Defend");
            Console.WriteLine("4) Run");
            Console.Write("Choose (1-4): ");
            int.TryParse(Console.ReadLine(), out int command);

            switch (command)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire!");
                    break;
                case 3:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 4:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }
            int power = command switch
            {
                1 => 12,
                2 => 18,
                _ => 0
            };
            int damage = Math.Max(0, power - monsterDefense);
            Console.WriteLine($"Damage: {damage}");
            string rating = damage switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating}");

            string monsterStatus = damage >= MonsterHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus}");

            Console.Write("Really run away? (y/n): ");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;
            }

            // Part B

            const int SlimeHp = 20;
            const int MaxHeroHp = 30;
            int currentHeroHp = 17;
            int currentSlimeHp = SlimeHp;

            Console.WriteLine("\n=== Status ===");
            Console.WriteLine($"Hero HP: {currentHeroHp} / {MaxHeroHp}");
            Console.WriteLine($"Slime HP: {currentSlimeHp} / {SlimeHp}");

            Console.Write("Slime Defense: ");
            int.TryParse(Console.ReadLine(), out int slimeDefense);
            Console.WriteLine($"A Slime appears! HP {SlimeHp}, DEF {slimeDefense}");
            Console.WriteLine();
            Console.WriteLine($"           ...:......           \r\n       .....   ...........      \r\n    .......:::;;;;;;::......    \r\n  ......:;;;;;;;;;;;;;;;:.....  \r\n .....:;;;;;;;;;;;;;;;;;;:..... \r\n......:;;;;;;;;;;;;;;;;;;.......\r\n..::::::;;;;;;;;;;;;;;;::::;:...\r\n..::::::;;;;;;;;;;;;;;::::::::..\r\n.:;;;;;;;;;;;;;;;;;;;;;;;;;;;;:.\r\n .:;;;;;;;;;;;;;;;;;;;;;;;;;::. \r\n  +x::::;;;;;;;;;;;;:::::::+XX. \r\n    ..:;;;+++xXXXXxXXXX$$X;..   ");
            Console.WriteLine();

            Console.WriteLine("\n=== BATTLE MENU ===");
            Console.WriteLine("1) Attack");
            Console.WriteLine("2) Fire Magic");
            Console.WriteLine("3) Heal");
            Console.WriteLine("4) Defend");
            Console.WriteLine("5) Run");
            Console.Write("Choose (1-5): ");

            int.TryParse(Console.ReadLine(), out int command2);

            switch (command2)
            {
                case 1:
                    Console.WriteLine("Hero swings the sword!");
                    break;
                case 2:
                    Console.WriteLine("Hero casts Fire Magic!");
                    break;
                case 3:
                    Console.WriteLine("Hero uses Heal!");
                    break;
                case 4:
                    Console.WriteLine("Hero raises the shield.");
                    break;
                case 5:
                    Console.WriteLine("Hero looks for a way out...");
                    break;
                default:
                    Console.WriteLine("Hero hesitates. Invalid command!");
                    break;
            }
            int power2 = command2 switch
            {
                1 => 12,
                2 => 18,
                _ => 0
            };
            int damage2 = Math.Max(0, power2 - slimeDefense);
            Console.WriteLine($"Damage: {damage2}");
            string monsterStatus2 = damage2 >= SlimeHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {monsterStatus2}");
            Console.WriteLine();
            string rating2 = damage2 switch
            {
                >= 12 => "Critical hit!",
                >= 5 => "Solid hit.",
                > 0 => "Scratch.",
                _ => "No damage."
            };
            Console.WriteLine($"Rating: {rating2}");

            int HealPower = command2 switch
            {
                3 => 15,
                _ => 0
            };
            int HealAmount = Math.Max(0, HealPower);
            Console.WriteLine($"Heal Amount: {HealAmount}");
            string HeroStatus = HealAmount > 0 ? "Hero healed!" : "No healing.";
            Console.WriteLine($"Hero: {HeroStatus}");
            int currentHeroHpAfterHeal = Math.Min(MaxHeroHp, currentHeroHp + HealAmount);
            Console.WriteLine($"Hero HP after healing: {currentHeroHpAfterHeal} / {MaxHeroHp}");

            string slimeStatusAfterAttack = damage2 >= SlimeHp ? "DEFEATED" : "still standing";
            Console.WriteLine($"Slime: {slimeStatusAfterAttack}");

            Console.Write("Really run away? (y/n): ");
            string answer2 = Console.ReadLine();

            string runAwayStatus = answer2 switch
            {
                "y" or "Y" => "You escaped!",
                "n" or "N" => "You stay and fight.",
                _ => "Please type y or n."
            };

            switch (answer2)
            {
                case "y":
                case "Y":
                    Console.WriteLine("You escaped!");
                    break;
                case "n":
                case "N":
                    Console.WriteLine("You stay and fight.");
                    break;
                default:
                    Console.WriteLine("Please type y or n.");
                    break;









            }
        }
    }
}
