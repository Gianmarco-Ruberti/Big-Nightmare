using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BigNightmare
{
    public partial class Mob
    {
        private float _x;
        private float _y;
        public Rectangle Hitbox => new Rectangle((int)_x, (int)_y, 64, 64); // taille du mob

        public Mob(float x, float y)
        {
            _x = x;
            _y = y;
        }

        public int X { get { return (int)_x; } set { _x = value; } }
        public int Y { get { return (int)_y; } set { _y = value; } }

        public void Update(int interval)
        {
        }
    }
}