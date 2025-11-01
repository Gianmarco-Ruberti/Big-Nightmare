using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNightmare
{
    public partial class MobRed : Mob
    {
        public MobRed(float x, float y) : base(x, y, 3) { }

        public void Update(int interval)
        {
            base.Update(interval);
        }
    }
}

