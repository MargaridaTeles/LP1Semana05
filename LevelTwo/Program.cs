using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                CanvasImage image = new CanvasImage("tux.jpg");

                image.MaxWidth(20);

                AnsiConsole.Write(image);
            }
        }
    }
}
