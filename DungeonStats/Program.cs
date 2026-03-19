using System;
using Spectre.Console;

namespace DungeonStats
{

    public class Program
    {
        private static void Main(string[] args)
        {
            var table = new Table()
                .RoundedBorder()
                .BorderColor(Color.Grey);

            table.AddColumn("Operation");
            table.AddColumn("Result");
            

            if (args.Length == 1)
            {
                table.AddRow($"Damage {args[0]}");
                table.AddRow($"Damage {args[0]}");
                table.AddRow($"CriticalHit {args[0]}");
            }

            AnsiConsole.Write(table);

        }

        private static int Damage(int attack, int defense)
        {
            return attack - defense;
        }

        private static int Damage(int attack)
        {
            // Devolve dano sem defesa
            return attack;
        }

        private static int CriticalHit(int damage)
        {
            // devolve a soma de 1 até Damage(attack, defense) se damage <= 0 e devolve 0
            if (damage <= 0)
                return 0;

            return damage + CriticalHit(damage - 1);;
        }
        
    }
}
