using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace big_nightmare
{
    internal class Joueurs
    {
        private string[] view =
        {
            @"    ______",
            @"  /        \",
            @" |  @    @  |",
            @"  \        /",
            @"  /        \",
            @" /          \",
            @"/            \"
        };
        private int X;
        private int Y;
        public Joueurs() 
        {
            X = 20;
            Y = 50;
        }
        public void update()
        {
            ConsoleKeyInfo keyPressed;
            Console.Clear();
            if (Console.KeyAvailable)
            {
                keyPressed = Console.ReadKey(false);
                switch (keyPressed.Key)
                {
                    case ConsoleKey.W:
                        Y+=10;
                        break;

                    case ConsoleKey.A:
                        X-=10;
                        break;
                    case ConsoleKey.S:
                        Y-=10;
                        break;

                    case ConsoleKey.D:
                        X+=10;
                        break;
                }
            }
        }
        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(X, Y);
                Console.Write(view[i]);
            }
        }
    }
}
