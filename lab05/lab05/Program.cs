using System.Runtime.ConstrainedExecution;

namespace lab05
/*
* Student ID : 1690702509
* Name       : Leb02
* Section    : 129C
* No.        : 15
* Course     : GI113 Computer Programming (GI)
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Game title, Sub-title
            Console.WriteLine("==>Test My Game<==");
            Console.WriteLine("Hero vs. Moster, Fight Damage calculation\n");

            // Hero stats input
            Console.Write("Hero Health: ");
            bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
            Console.Write("Hero Attack: ");
            bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
            Console.Write("Hero Defense: ");
            bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

            // Moster stats input
            Console.Write("Moster Health: ");
            bool mosterHpOk = int.TryParse(Console.ReadLine(), out int mosterHp);
            Console.Write("Moster Attack: ");
            bool mosterAtkOk = int.TryParse(Console.ReadLine(), out int mosterAtk);
            Console.Write("Moster Defense: ");
            bool mosterDefOk = int.TryParse(Console.ReadLine(), out int mosterDef);

            // input validation
            bool isheroIntValid = heroHpOk && heroAtkOk && heroDefOk;
            bool ismosterIntValid = mosterHpOk && mosterAtkOk && mosterDefOk;
            Console.WriteLine($"\nHERO STATS VALID: {isheroIntValid}");
            Console.WriteLine($"MOSTER STATS VALID: {ismosterIntValid}");

            Console.WriteLine($"\nHero Stats: HP={heroHp}, ATK={heroAtk}, DEF={heroDef}");
            Console.WriteLine($"Moster Stats: HP={mosterHp}, ATK={mosterAtk}, DEF={mosterDef}\n");
            //Bool allInputValid = isheroIntValid && ismosterIntValid;
            // ถ้าเอาแค่ชื่อ bool มาเช็ก คือ เช็กว่าเป็นจริงมั้ย? แต่ถ้าใส่ ! ด้านหน้าคือตรงข้าม (จริง -> เท็จ)

            // Compound assignment : +=
            int potionHeal = 8;
            // heroHp = heroHp + potionHeal;
            heroHp += potionHeal;
            Console.WriteLine($"Hero used potion, heal {potionHeal} HP, new HP = {heroHp}\n");

            // Arithmetic + การโจมตีธรรมดา
            int normalDamage = Math.Max(0, heroAtk - mosterDef); //ความแรงการโจมตีขึ้นอยู่กับค่าป้องกันของมอนสเตอร์
            Console.WriteLine($"\nHero normal attack would deal: {normalDamage} DMG");

            // Precedence การโจมตีพิเศษ
            int pwrDmg = Math.Max(0, (heroAtk * 2) - mosterDef); // โจมตีคูณ 2 จะใส่วงเล็กหรือไม่ใส่วงเล็กก็ได้ แต่ใส่วงเล็กจะทำให้โค้ดอ่านง่ายขึ้น
            Console.WriteLine($"Hero power attack would deal: {pwrDmg} DMG");

            // Random, simple percent chance
            Random RNG = new Random();
            int roll = RNG.Next(1, 100 + 1); //ต้อง +1 ค่ามากสุดเสมอ เช่นอยากได้ 100 ต้อง 101 เสมอ
            bool isCrit = roll <= 99; // 10% chance จาก 100
            int critDmg = normalDamage + Convert.ToInt32(isCrit) * normalDamage; // ถ้า isCrit เป็นจริง จะได้ค่า 1 * normalDamage แต่ถ้าเป็นเท็จ จะได้ค่า 0 * normalDamage
            Console.WriteLine($"\nCritical hit roll: {roll} (Critical: { isCrit})");
            Console.WriteLine($"If critical, normal attack would increase deal: {critDmg}");


        }
    }
}
