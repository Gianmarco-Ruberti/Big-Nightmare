using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNightmare
{
    public partial class Bullet
    {
        public int bx;                                 // Position en X depuis la gauche de l'espace aérien
        public int by;                                 // Position en Y depuis le haut de l'espace aérien

        // Constructeur
        public Bullet(int x, int y)
        {
            bx = x;
            by = y;
        }
        public int X { get { return bx; } set { bx = value; } }
        public int Y { get { return by; } set { by = value; } }

        public void Update(int interval)
        {
            by -= 1;
        }
    }
}
