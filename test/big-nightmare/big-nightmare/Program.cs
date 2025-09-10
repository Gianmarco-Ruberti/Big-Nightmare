using big_nightmare;
using System;
using System.Numerics;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.CursorVisible = false;
            Console.WindowWidth = Config.SCREEN_WIDTH;
            Console.WindowHeight = Config.SCREEN_HEIGHT;
            ConsoleKeyInfo keyPressed;
            Joueurs joueur = new Joueurs();
            while (true)
            {
                Console.Clear();
                if (Console.KeyAvailable) // L'utilisateur a pressé une touche
                {
                    keyPressed = Console.ReadKey(false);
                    switch (keyPressed.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0);
                            break;

                        case ConsoleKey.W:
                          
                            break;
                    }
                }
                // Modifier le modèle (ce qui *est*)
                joueur.update();

                // Modifier ce que l'on *voit*
                Console.Clear();
                joueur.draw();
                

                // Temporiser
                Thread.Sleep(100);
            }
        }
    }
}