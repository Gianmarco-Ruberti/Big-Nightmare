using System;

namespace BigNightmare
{
    public partial class MobYellow : Mob
    {
        private DateTime lastShotTime = DateTime.MinValue;
        private readonly TimeSpan shotCooldown = TimeSpan.FromSeconds(1);

        public MobYellow(float x, float y) : base(x, y) { }

        public void Update(int interval, Player player, List<Bullet> bullets)
        {
            // tir automatique
            if (DateTime.Now - lastShotTime >= shotCooldown)
            {
                lastShotTime = DateTime.Now;

                // cible : centre du joueur
                int targetX = player.X + player.Hitbox.Width / 2;
                int targetY = player.Y + player.Hitbox.Height / 2;

                Bullet bullet = new Bullet(X + 32, Y + 32, targetX, targetY);
                bullets.Add(bullet);
            }
        }
    }

}
