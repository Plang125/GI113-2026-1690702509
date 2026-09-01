namespace Leb03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Maxlevel = 10;

            var BossName = "kirin";
            var rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 115;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isboss = true;

            Console.WriteLine("===== kirin SAVE CONVERTER =====");
            Console.WriteLine($"Boss Name: {BossName}" +
                 $"\nRank: {rank}" +
                 $"\nLevel: {level}" +
                 $"\nMax HP: {maxHp}" +
                 $"\nCurrent HP: {currentHp}" +
                 $"\nAttack Power: {attackPower}" +
                 $"\nCritical Multiplier: {critMultiplier}" +
                 $"\nIs Boss: {isboss}");

           // -----Implicit Conversion: HP as double -----
           Console.WriteLine("\n----- Implicit Conversion: HP as double -----");
                       double currentHpDouble = currentHp;
           Console.WriteLine($"Current HP as double: {currentHpDouble}");

            // Calculate Percentage
            Console.WriteLine("\n----- Exact HP Percent (no integer truncation) -----");
            double hpPercentExact = currentHpDouble * 100 / maxHp;
            Console.WriteLine($"Hp Percent (exaact):{hpPercentExact}");

            // Explicit float (attackPower) -->> int
            Console.WriteLine("\n----- Explicit Conversion: Attack Power as int -----");
            int attackPowerInt = (int)attackPower;
            Console.WriteLine($"Attack Power (int): {attackPowerInt}");

            // Cast vs Convert double(critMultiplier) -->> int
            Console.WriteLine("\n----- Cast vs Convert: Critical Multiplier as int -----");
            int critCast = (int)critMultiplier;
            int critConvert = Convert.ToInt32(critMultiplier);
            Console.WriteLine($"Crit Multiplier (int cast): {critCast}");
            Console.WriteLine($"Crit Multiplier (int convert): {critConvert}");



        }
    }
}
