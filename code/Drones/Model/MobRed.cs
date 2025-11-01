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
        public MobRed(float x, float y) : base(x, y, 3) { }

        public void Update(int interval, Player player, List<MobRed> mobRed, List<MobMort> mobMort)
        {
            if (pv <= 0)
            {
                mobRed.Remove(this);
                mobMort.Add(new MobMort());
                return;
            }
            base.Update(interval);
        }
    }
}

