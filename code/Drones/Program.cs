using System.Linq.Expressions;

namespace BigNightmare
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Création du joueur
            Player player = new Player(1900/2, 1080/2);

            //création des bloc
            int centerX = 100;
            int centerY = 100;
            int radius = 50;

            // Position initiale sur le cercle, par exemple à droite (angle 0°)
            int startX = centerX + radius;
            int startY = centerY;

            Block block = new Block(startX, startY);
            block.Add(new Block(925, 375));
            block.Add(new Block(1075, 500));
            block.Add(new Block(1025, 650));
            block.Add(new Block(825, 650));
            block.Add(new Block(775, 500));
            
            List<Bullet> bullet = new List<Bullet>();
            

            // Démarrage
            Application.Run(new PlayZone(player, block, bullet));
        }
    }
}