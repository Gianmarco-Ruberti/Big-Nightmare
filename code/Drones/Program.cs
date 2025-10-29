using System;
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

            int centerX = 960; // par exemple si ta fenêtre fait 1920x1080
            int centerY = 540;
            int minDistance = 400;

            // Création du joueur
            Player player = new Player(988, 467);

            //base pour générer les position
            Random random = new Random();
            int nombreRed = 9;
            int nombreYellow = 3;
            int i = 0;

            // Position initiale sur le cercle
            List<Block> block = new List<Block>();
            block.Add(new Block(925, 285, 360));
            block.Add(new Block(1050, 375, 288));
            block.Add(new Block(1005, 525, 216));
            block.Add(new Block(845, 525, 144));
            block.Add(new Block(800, 375,72));

            List<Bullet> bullet = new List<Bullet>();


            List<MobRed> mobRed = new List<MobRed>();
            do
            {
                int positionX = random.Next(100, 1600);
                int positionY = random.Next(100, 800);
                double distance = Math.Sqrt(Math.Pow(positionX - centerX, 2) + Math.Pow(positionY - centerY, 2));
                if (distance >= minDistance)
                {
                    mobRed.Add(new MobRed(positionX, positionY));
                    Console.WriteLine($"position du mobRed = {positionX}, {positionY}");
                    i++;
                }
            }while (i < nombreRed);
            i = 0;
            List < MobYellow > mobYellow = new List<MobYellow>();
            do
            {
                int positionX = random.Next(100, 1600);
                int positionY = random.Next(100, 800);
                double distance = Math.Sqrt(Math.Pow(positionX - centerX, 2) + Math.Pow(positionY - centerY, 2));
                if (distance >= minDistance)
                {
                    mobYellow.Add(new MobYellow(positionX, positionY));
                    Console.WriteLine($"position du mobYellow = {positionX}, {positionY}");
                    i++;
                }
            } while (i < nombreYellow);
            i = 0;

            // Démarrage
            Application.Run(new PlayZone(player, block, bullet, mobRed, mobYellow));
        }
    }
}