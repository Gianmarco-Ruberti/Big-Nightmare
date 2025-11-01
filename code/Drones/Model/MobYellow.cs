using BigNightmare.Model;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BigNightmare
{
    public partial class MobYellow : Mob
    {
        private int pv = 10;
        private DateTime lastShotTime = DateTime.MinValue;
        private readonly TimeSpan shotCooldown = TimeSpan.FromSeconds(1);

        public MobYellow(float x, float y) : base(x, y) { }

        // Mise à jour avec tir + mort
        public void Update(int interval, Player player, List<Bullet> bullets, List<MobYellow> mobYellows, List<MobMort> mobMort)
        {
            if (pv < 0) 
            // Vérifie si mort
            if (pv <= 0)
            {
                mobYellows.Remove(this);
                mobMort.Add(new MobMort());
                return;
            }
           /* // tir automatique
            if (DateTime.Now - lastShotTime >= shotCooldown)
            {
                lastShotTime = DateTime.Now;

                // cible : centre du joueur
                int targetX = player.X + player.Hitbox.Width / 2;
                int targetY = player.Y + player.Hitbox.Height / 2;

                Bullet bullet = new Bullet(X + 32, Y + 32, targetX, targetY);
                bullets.Add(bullet);
            }*/
        }
    }

}
