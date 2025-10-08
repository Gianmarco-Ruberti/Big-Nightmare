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

            
            List<Block> block = new List<Block>();
            block.Add(new Block(925, 285, 360));
            block.Add(new Block(1050, 375, 288));
            block.Add(new Block(1005, 525, 216));
            block.Add(new Block(845, 525, 144));
            block.Add(new Block(800, 375,72));
            
            List<Bullet> bullet = new List<Bullet>();
            

            // Démarrage
            Application.Run(new PlayZone(player, block, bullet));
        }
    }
}