using System;
/*
* Student ID : 1690702509
* Name       : Rathaphol Chaowlumbua
* Section    : 129C
* No.        : 15
* Course     : GI113 Computer Programming (GI)
*/
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string Gametitle = "Fantasy World";
           
            var Character = "Darin";
            var CharacterRank = 'S';
            int CharacterLevel = 99;
            float critChance = 0.75f;
            double critDamage = 150.5;
            bool isPlayable = true;


            Console.WriteLine($"/====================================================\\\r\n||          _____                    _____          ||\r\n||         /\\    \\                  /\\    \\         ||\r\n||        /::\\    \\                /::\\____\\        ||\r\n||       /::::\\    \\              /:::/    /        ||\r\n||      /::::::\\    \\            /:::/   _/___      ||\r\n||     /:::/\\:::\\    \\          /:::/   /\\    \\     ||\r\n||    /:::/__\\:::\\    \\        /:::/   /::\\____\\    ||\r\n||   /::::\\   \\:::\\    \\      /:::/   /:::/    /    ||\r\n||  /::::::\\   \\:::\\    \\    /:::/   /:::/   _/___  ||\r\n|| /:::/\\:::\\   \\:::\\    \\  /:::/___/:::/   /\\    \\ ||\r\n||/:::/  \\:::\\   \\:::\\____\\|:::|   /:::/   /::\\____\\||\r\n||\\::/    \\:::\\   \\::/    /|:::|__/:::/   /:::/    /||\r\n|| \\/____/ \\:::\\   \\/____/  \\:::\\/:::/   /:::/    / ||\r\n||          \\:::\\    \\       \\::::::/   /:::/    /  ||\r\n||           \\:::\\____\\       \\::::/___/:::/    /   ||\r\n||            \\::/    /        \\:::\\__/:::/    /    ||\r\n||             \\/____/          \\::::::::/    /     ||\r\n||                               \\::::::/    /      ||\r\n||                                \\::::/    /       ||\r\n||                                 \\::/____/        ||\r\n||                                  ~~              ||\r\n\\====================================================/");
            Console.WriteLine($"=================================={Gametitle}==================================");
            Console.WriteLine($"Character: {Character}");
            Console.WriteLine($"Character Rank: {CharacterRank}");
            Console.WriteLine($"Character Level: {CharacterLevel}");
            Console.WriteLine($"Critical Chance: {critChance}");
            Console.WriteLine($"Critical Damage: {critDamage}");
            Console.WriteLine($"Is Playable: {isPlayable}");
            Console.WriteLine($"===============================================================================");

            double characterLevelAsDouble = CharacterLevel;
            Console.WriteLine($"level as double(implicit): {characterLevelAsDouble}");

            int critDamageTruncated = (int)critDamage;
            int critDamageRounded = Convert.ToInt32(critDamage);

            Console.WriteLine($"Critical Damage cast (Truncated): {critDamageTruncated}");
            Console.WriteLine($"Critical Damage Convert (Rounded): {critDamageRounded}");

        }
    }
}