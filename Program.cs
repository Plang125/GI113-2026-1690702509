using System;
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
            Console.WriteLine();
            string characterName1 = "Jojo";
            char rank1 = 'S';
            int level1 = 15;
            int maxHp1 = 500;
            float attackPower1 = 72.5f;
            double critMultiplier1 = 1.75;
            bool male1 = true;
            Console.WriteLine();

            // ประกาศตัวแปร 6 ตัว
            Console.WriteLine("===== Jojo STATUS: INITIAL =====");
            Console.WriteLine($"Name:{characterName1}");
            Console.WriteLine($"Rank:{rank}");
            Console.WriteLine($"Attack Power:{attackPower1}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier1}");
            Console.WriteLine($"Is Boss:{male1}");

            Console.WriteLine();
            string characterName2 = "darin";    
            char rank2 = 'S';              
            int level2 = 8;                
            int maxHp2 = 300;
            float attackPower2 = 55.5f;    
            double critMultiplier2 = 1.75; 
            bool male2 = true;
            Console.WriteLine();
            // ประกาศตัวแปร 6 ตัว
            Console.WriteLine("===== Darin STATUS: INITIAL =====");
            Console.WriteLine($"Name:{characterName2}");
            Console.WriteLine($"Rank:{rank2}");
            Console.WriteLine($"Attack Power:{attackPower2}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier2}");
            Console.WriteLine($"Is Boss:{male2}");
            Console.WriteLine();

            string characterName3 = "Jack";
            char rank3 = 'S';
            int level3 = 14;
            int maxHp3 = 600;
            float attackPower3 = 95.5f;
            double critMultiplier3 = 1.75;
            bool male3 = true;
            Console.WriteLine();
            // ประกาศตัวแปร 6 ตัว
            Console.WriteLine("===== Jack STATUS: INITIAL =====");
            Console.WriteLine($"Name:{characterName3}");
            Console.WriteLine($"Rank:{rank3}");
            Console.WriteLine($"Attack Power:{attackPower3}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier3}");
            Console.WriteLine($"Is Boss:{male3}");

            Console.WriteLine();

            string characterName4 = "Porza";
            char rank4 = 'S';
            int level4 = 30;
            int maxHp4 = 1600;
            float attackPower4 = 295.5f;
            double critMultiplier4  = 1.75;
            bool male4 = true;
            Console.WriteLine();
            // ประกาศตัวแปร 6 ตัว
            Console.WriteLine("===== Porza STATUS: INITIAL =====");
            Console.WriteLine($"Name:{characterName4}");
            Console.WriteLine($"Rank:{rank4}");
            Console.WriteLine($"Attack Power:{attackPower4}");
            Console.WriteLine($"Crit Multiplier:{critMultiplier4}");
            Console.WriteLine($"Is Boss:{male4}");

            Console.WriteLine();

            // การปริ้นลง Console เว้น บรรทัด #1
            Console.WriteLine();
            // การปริ้นลง Console เว้น บรรทัด #2
            Console.WriteLine("\n");

            // Example 1
            Console.WriteLine("I GO TO SCHOOL");
            Console.WriteLine(); //เว้นบรรทัด
            Console.WriteLine("I AM HUNGRY");
            // Example 2
            Console.WriteLine("I GO TO SCHOOL\n"); // เว้นบรรทัด
            Console.WriteLine("I AM HUNGRY");

            // format การพิมพ์ข้อความ
            // Example 1 การพิมพ์ทีละบรรทัด
            Console.WriteLine("I AM SLEEPY");
            Console.WriteLine("I GO TO SLEEP");
            Console.WriteLine("I WOKE UP");
            // Example 2 การพิมพ์แบบประหยัดบรรทัดโค๊ด
            Console.WriteLine("I AM SLEEPY\nI GO TO SLEEP\nI WOKE UP");
            // Example 3 Hybrid รวมทั้งสองแบบ
            Console.WriteLine("I AM SLEEPY" +
                "\nI GO TO SLEEP" +
                "\nI WOKE UP");
        }

    }

    }
}
