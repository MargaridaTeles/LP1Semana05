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

                image.MaxWidth(24);

                AnsiConsole.Write(image);
            }
            else
            {
                string local = args[0];
                int largura = int.Parse(args[1]);

                CanvasImage image = new CanvasImage(local);

                image.MaxWidth(largura);

                AnsiConsole.Write(image);
            }
        }
    }
}
