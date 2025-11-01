using BigNightmare.Model;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BigNightmare
{
    public partial class MobYellow : Mob
    {
        private DateTime lastShotTime = DateTime.MinValue;
        private readonly TimeSpan shotCooldown = TimeSpan.FromSeconds(5);

        public MobYellow(float x, float y) : base(x, y, 1) { }

        // Mise à jour avec tir + mort
        public void Update(int interval, Player player, List<Bullet> bullets, List<MobYellow> mobYellow, List<MobMort> mobMort)
        {
            // Vérifie si mort
            if (pv <= 0)
            {
                mobYellow.Remove(this);
                mobMort.Add(new MobMort());
                return;
            }

            // Tir automatique vers le joueur
            if (DateTime.Now - lastShotTime >= shotCooldown)
            {
                lastShotTime = DateTime.Now;

                // vise le centre du joueur
                int targetX = player.X + player.Hitbox.Width / 2;
                int targetY = player.Y + player.Hitbox.Height / 2;

                Bullet bullet = new Bullet(X + 45, Y + 45, targetX, targetY);
                bullets.Add(bullet);
            }
        }
    }
}
