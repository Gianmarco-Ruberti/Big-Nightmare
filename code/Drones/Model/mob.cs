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
        protected float _x;
        protected float _y;
        protected int pv;
        public Rectangle Hitbox => new Rectangle((int)_x, (int)_y, 90, 90); // taille du mob

        public Mob(float x, float y, int hp)
        {
            _x = x;
            _y = y;
            pv = hp;
        }

        public int X { get { return (int)_x; } set { _x = value; } }
        public int Y { get { return (int)_y; } set { _y = value; } }

        public bool IsDead => pv <= 0;

        public void TakeDamage(int damage)
        {
            pv -= damage;
        }

        public void Update(int interval)
        {
        }
    }
}