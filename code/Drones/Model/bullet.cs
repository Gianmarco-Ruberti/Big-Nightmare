using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNightmare
{
    public partial class Bullet
    {
        private float angle;
        public float Speed = 10f;                      // vitesse de la balle
        private float dx;                              // déplacement X par frame
        private float dy;                              // déplacement Y par frame
        public float bx;                                 // Position en X depuis la gauche de l'espace aérien
        public float by;                                 // Position en Y depuis le haut de l'espace aérien

        // Constructeur
        public Bullet(int startX, int startY, int targetX, int targetY)
        {
            bx = startX;
            by = startY;

            // Calcul du vecteur direction
            float deltaX = targetX - startX;
            float deltaY = targetY - startY;
            float length = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            dx = deltaX / length * Speed;
            dy = deltaY / length * Speed;
            angle = (float)(Math.Atan2(dy, dx) * 180 / Math.PI);
            angle -= 90f;
        }
        public int X { get { return (int)bx; } set { bx = value; } }
        public int Y { get { return (int)by; } set { by = value; } }

        public void Update(int interval)
        {
            bx += dx;
            by += dy;
        }
    }
}
