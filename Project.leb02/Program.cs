namespace project_129C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "kirin";    // string เอาไว้เก็บข้อความตัวอังษรใน "..."
            char rank = 'S';              // char เอาไว้เก็บตัวอักษรตัวเดัยวใน '.'
            int level = 7;                // int เอาไว้เก็บตัวเลขจำนวนเต็มบวก, เต็มลบ, 0
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;    // เอาไว้เก็บตัวเลชที่มีทศนิยม และต้องต่อท้ายด้วย f
            double critMultiplier = 1.75; // เอาไว้เก็บตัวเลขที่มีทศนิยม เก็บได้มากกว่า float
            bool isBoss = true;           // เอาไว้เก็บ true หรือ false

            // ประกาศตัวแปร 6 ตัว
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name:{bossName}");
            Console.WriteLine($"Rank:{rank}");
            Console.WriteLine($"HP:{currentHp}/{maxHp}");
            Console.WriteLine($"Attack Power:{attackPower}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier}");
            Console.WriteLine($"Is Boss:{isBoss}");

            Console.WriteLine();
            // คำนวณเปอร์เซ็น
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {currentHp} / {maxHp}");
            Console.WriteLine();
            Console.WriteLine("kirin takes 60 damage");
            Console.WriteLine();
            // ลด HP 60 หน่วย
            currentHp = currentHp - 60;
            Console.WriteLine();

            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;


        }
    }
}
