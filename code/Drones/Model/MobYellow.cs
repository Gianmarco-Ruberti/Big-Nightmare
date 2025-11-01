using System;
using System.Collections.Generic;
using System.Drawing;

namespace BigNightmare
{
    public partial class MobYellow : Mob
    {
        private DateTime lastShotTime = DateTime.MinValue;
        private TimeSpan shotCooldown = TimeSpan.FromSeconds(4);
        private DateTime lastCooldownDecrease = DateTime.Now;
        private TimeSpan minCooldown = TimeSpan.FromSeconds(1);

        public MobYellow(float x, float y) : base(x, y, 1) { }

        // Mise à jour avec tir + mort
        public void Update(int interval, Player player, List<Bullet> bullets, List<MobYellow> mobYellow, List<MobMort> mobMort)
        {
            if ((DateTime.Now - lastCooldownDecrease).TotalSeconds >= 45 && shotCooldown.TotalSeconds > 1)
            {
                shotCooldown = shotCooldown - TimeSpan.FromSeconds(1);
                if (shotCooldown < minCooldown)
                    shotCooldown = minCooldown;

                lastCooldownDecrease = DateTime.Now;
            }

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
