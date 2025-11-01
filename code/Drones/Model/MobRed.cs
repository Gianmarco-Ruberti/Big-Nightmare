using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BigNightmare.Model;

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
                    return; // collision détectée, ne bouge pas
                }
            }

            _x += dx;
            _y += dy;
        }

        public void Update(int interval, Player player, List<MobRed> mobRed, List<MobMort> mobMort, List<Block> blocks)
        {
            base.Update(interval);

            float dx = player.X - _x;
            float dy = player.Y - _y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance > 0)
            {
                float moveX = dx / distance * speed;
                float moveY = dy / distance * speed;
                Move(moveX, moveY, blocks);
            }

            if ((DateTime.Now - lastSpeedIncrease).TotalSeconds >= 30 && speed < 6)
            {
                speed++;
                lastSpeedIncrease = DateTime.Now;
            }


            if (pv <= 0)
            {
                mobRed.Remove(this);
                mobMort.Add(new MobMort());
                return;
            }
        }
    }
}

