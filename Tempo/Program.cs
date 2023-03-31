using System;
using System.Diagnostics;
using System.Threading;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500);

            crono2.Start();
            Thread.Sleep(300);

            crono1.Stop();
            crono2.Stop();

            TimeSpan ts1 = crono1.Elapsed;
            TimeSpan ts2 = crono2.Elapsed;

            string elapsedTime1 = String.Format("{0:F2}", ts1.TotalSeconds);
            Console.WriteLine($"Cronometro 1: {elapsedTime1}");

            string elapsedTime2 = String.Format("{0:F2}", ts2.TotalSeconds);
            Console.WriteLine($"Cronometro 2: {elapsedTime2}");
        }
    }
}