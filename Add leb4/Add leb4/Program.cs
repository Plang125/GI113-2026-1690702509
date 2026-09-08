namespace Add_leb4
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
            //Console.WriteLine("+--------------------+");
            //Console.WriteLine("|   NEW ADVENTURE    |");
            //Console.WriteLine("+--------------------+");

            //Console.WriteLine("Name your Hero: ");
            //string playerName = Console.ReadLine();

            //Console.WriteLine($"\nWelcome, {playerName}. Your journey begins..");

            //Console.WriteLine("+-----------------------+");
            //Console.WriteLine("|   DIFFICULTY SELECT   |");
            //Console.WriteLine("+-----------------------+");
            //Console.Write("choose difficulty (1-3): ");
            ///int difficulty = Convert . ToInt32(Console.ReadLine());
            //Console.WriteLine($"\n\"Difficulty {difficulty} selected. Good luck out there..\"");

            //Console.WriteLine("+--------------------+");
            //Console.WriteLine("|      ITEM SHOP     |");
            //Console.WriteLine("+--------------------+");
            //Console.Write("How many potions? ");
            //bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            //Console.WriteLine($"Valid input: {isValid}");
            //Console.WriteLine($"Quantity: {quantity}");

            //Console.WriteLine("+------------------------+");
            //Console.WriteLine("|   CHARACTER CREATION   |");
            //Console.WriteLine("+------------------------+");
            //Console.Write("Name your character: ");
            //string charName = Console.ReadLine();
            //Console.Write("Choose your class (1-3): ");
            //bool class0k = int.TryParse(Console.ReadLine(), out int classNam);
            //Console.Write("Starting luck (0.0-10.0): ");
            //bool luck0k = double.TryParse(Console.ReadLine(), out double luck);
            //Console.WriteLine($"\n{charName} the class-{classNam} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|      CHARACTER CREATION       |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"{charName} the Class-{classNum} adventurer enters the dungeon. Luck: {luck}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|           ITEM SHOP           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("How many potions? ");
            bool quantityOk = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {quantityOk}");
            Console.WriteLine($"Quantity: {quantity}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|          SET VOLUME           |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Set music volume (0.0-1.0): ");
            bool volumeOk = double.TryParse(Console.ReadLine(), out double volume);
            Console.WriteLine($"Valid input: {volumeOk}");
            Console.WriteLine($"Volume: {volume}");

            Console.WriteLine("+------------------------------+");
            Console.WriteLine("|         NEW SAVE FILE         |");
            Console.WriteLine("+------------------------------+");
            Console.Write("Enter save name: ");
            string saveName = Console.ReadLine();
            Console.Write("Choose save slot (1-3): ");
            bool slotOk = int.TryParse(Console.ReadLine(), out int slot);
            Console.WriteLine($"Save name: {saveName}");
            Console.WriteLine($"Valid input: {slotOk}");
            Console.WriteLine($"Slot: {slot}");
        }
        
    }
}
