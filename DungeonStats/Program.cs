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
        
    }
}
