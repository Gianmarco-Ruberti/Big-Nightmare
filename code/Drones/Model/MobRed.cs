using System;
using System.Collections.Generic;
using System.Drawing;

namespace BigNightmare
{
    public partial class MobRed : Mob
    {
        private float speed = 1f;
        private DateTime lastSpeedIncrease = DateTime.Now;

        public MobRed(float x, float y) : base(x, y, 3) { }

        public void Move(float dx, float dy, List<Block> blocks)
        {
            Rectangle nextPos = new Rectangle((int)(_x + dx), (int)(_y + dy), Hitbox.Width, Hitbox.Height);

            foreach (var block in blocks)
            {
                if (block.LeftCircle.collision(nextPos) || block.RightCircle.collision(nextPos))
                {
                    return; // bloque le mob si collision
                }
            }

            _x += dx;
            _y += dy;
        }

        public void Update(int interval, Player player, List<MobRed> mobRed, List<MobMort> mobMort, List<Block> blocks)
        {
            // Collision avec le joueur
            if (this.Hitbox.IntersectsWith(player.Hitbox))
            {
                player.Damage(1);
            }

            // Collision avec les blocks → inflige 1 dégât
            foreach (var block in blocks)
            {
                if (block.LeftCircle.collision(this.Hitbox) || block.RightCircle.collision(this.Hitbox))
                {
                    Block.Damage(1);
                }
            }

            // Déplacement vers le joueur
            float dx = player.X - _x;
            float dy = player.Y - _y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance > 0)
            {
                float moveX = dx / distance * speed;
                float moveY = dy / distance * speed;
                Move(moveX, moveY, blocks);
            }

            // Augmentation de la vitesse toutes les 30s
            if ((DateTime.Now - lastSpeedIncrease).TotalSeconds >= 30 && speed < 6)
            {
                speed += 1f;
                lastSpeedIncrease = DateTime.Now;
            }

            // Mort du mob
            if (pv <= 0)
            {
                mobRed.Remove(this);
                mobMort.Add(new MobMort());
            }
        }
    }
}