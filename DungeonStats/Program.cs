using System;

namespace DungeonStats
{

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP!");
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
            int dano;

            if (damage <= 0)
                dano = 0;
            else
                dano = 1 + Damage(damage, 0);

            return dano;
        }
        
    }
}
