using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using BigNightmare.Model;

namespace BigNightmare
{
    public partial class MobRed : Mob
    {
        private float speed = 1f;
        private DateTime lastSpeedIncrease = DateTime.Now;
        public MobRed(float x, float y) : base(x, y, 3) { }

        public void Update(int interval, Player player, List<MobRed> mobRed, List<MobMort> mobMort)
        {
            base.Update(interval);

            float dx = player.X - X;
            float dy = player.Y - Y;
            float distance = (float)Math.Sqrt(dx * dx + dy * dy);

            if (distance > 0)
            {
                X += (int)(dx / distance * speed);
                Y += (int)(dy / distance * speed);
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

