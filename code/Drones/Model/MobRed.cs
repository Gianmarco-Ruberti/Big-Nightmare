using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNightmare
{
    public class MobRed : Mob
    {
        public MobRed(float x, float y) : base(x, y) { }

        public override void Update(int interval, Player player, List<Bullet> bullets)
        {
            base.Update(interval, player, bullets);
        }
    }
}

