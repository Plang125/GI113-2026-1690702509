namespace Assignment02
/*
* Student ID : 1690702509
* Name       : Assignment02
* Section    : 129C
* No.        : 15
* Course     : GI113 Computer Programming (GI)
*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"▐▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▌\r\n▐                                                                                                               ▌\r\n▐                                                                                                               ▌\r\n▐     █████████               █████                ██████     ███████████                                       ▌\r\n▐    ███░░░░░███             ░░███                ███░░███   ░░███░░░░░░█                                       ▌\r\n▐   ███     ░░░   ██████   ███████      ██████   ░███ ░░░     ░███   █ ░   ██████  ████████   ███████  ██████   ▌\r\n▐  ░███          ███░░███ ███░░███     ███░░███ ███████       ░███████    ███░░███░░███░░███ ███░░███ ███░░███  ▌\r\n▐  ░███    █████░███ ░███░███ ░███    ░███ ░███░░░███░        ░███░░░█   ░███ ░███ ░███ ░░░ ░███ ░███░███████   ▌\r\n▐  ░░███  ░░███ ░███ ░███░███ ░███    ░███ ░███  ░███         ░███  ░    ░███ ░███ ░███     ░███ ░███░███░░░    ▌\r\n▐   ░░█████████ ░░██████ ░░████████   ░░██████   █████        █████      ░░██████  █████    ░░███████░░██████   ▌\r\n▐    ░░░░░░░░░   ░░░░░░   ░░░░░░░░     ░░░░░░   ░░░░░        ░░░░░        ░░░░░░  ░░░░░      ░░░░░███ ░░░░░░    ▌\r\n▐                                                                                            ███ ░███           ▌\r\n▐                                                                                           ░░██████            ▌\r\n▐                                                                                            ░░░░░░             ▌\r\n▐                                                                                                               ▌\r\n▐                                                                                                               ▌\r\n▐▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▌");
            Console.WriteLine("=======================================\r\n-->   Welcome to the God of Forge   <--\r\n=======================================");
            int GodOre = 2;
            int GodIngot = 3;
            double GodOreRate = 0.25;
            double GodIngotRate = 0.15;
            Console.WriteLine($"God Ore Smelting {GodOreRate} / Salvage {GodIngotRate} ");
            Console.WriteLine("Key 'S' for Smelt");
            Console.WriteLine("Key 'B' for Breakdown");
            Console.Write("Choose Menu: : ");

            bool userInput = char.TryParse(Console.ReadLine(), out char Action);
            if (!userInput || Action < 'S'  && Action > 'B')
            {
                Console.WriteLine("Invalid menu!");
                return;
            }

            if (Action == 'S' && GodOre <= GodIngot )
            {
                Console.WriteLine();
                Console.WriteLine("=====================================");
                Console.WriteLine("----    God Ore --> God Ingot    ----");
                Console.WriteLine("=====================================");
                Console.Write("How much would you like: ");
                bool GodOreInput = double.TryParse(Console.ReadLine(), out double GodOreAmount);

                if (GodOreInput && GodOreAmount >= 0)
                {
                    double GodIngotAmount = GodOreAmount * 0.15;
                    Console.WriteLine($"{GodOreAmount} God Ingot is equal to {GodIngotAmount} God Ore.");
                    Console.WriteLine($"            /\\\r\n           /  \\\r\n      .---<    >---.\r\n      |   _\\  /_   |\r\n    _,',_|  \\/  |_,',_\r\n_.-'     '-./\\.-'     '-._\r\n '-._   _.-'\\/'-._   _.-'\r\n     `,` |__/\\__| `,`\r\n      |    /  \\    |\r\n      '---<    >---'\r\n           \\  /\r\n            \\/");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative number for God Ingot.");
                }

            }
            Console.WriteLine();
            if (Action == 'B' && GodIngot >= GodOre)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("----    God Ingot --> God Ore    ----");
                Console.WriteLine("=====================================");
                Console.Write("How much would you like: ");
                bool GodIngInput = double.TryParse(Console.ReadLine(), out double GodIngotAmount);

                if (GodIngInput && GodIngotAmount >= 0)
                {
                    double GodOreAmount = GodIngotAmount * 0.15;
                    Console.WriteLine($"{GodIngotAmount} God Ingot is equal to {GodOreAmount} God Ore.");
                    Console.WriteLine();
                    Console.WriteLine($"      _----------_,\r\n    ,\"__         _-:, \r\n   /    \"\"--_--\"\"...:\\\r\n  /         |.........\\\r\n /          |..........\\\r\n/,         _'_........./:\r\n! -,    _-\"   \"-_... ,;;:\r\n\\   -_-\"         \"-_/;;;;\r\n \\   \\             /;;;;'\r\n  \\   \\           /;;;;\r\n   '.  \\         /;;;'\r\n     \"-_\\_______/;;'\r\n");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a non-negative number for God Ingot.");
                }
                
            

            }

        }
    }
}
