using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNightmare
{
    public class CircleHitbox
    {
        public PointF Center { get; set; }
        public float Radius { get; set; }

        public CircleHitbox(float x, float y, float radius)
        {
            Center = new PointF(x, y);
            Radius = radius;
        }

        // Vérifie si un rectangle (joueur) touche ce cercle
        public bool collision(Rectangle rect)
        {
            float closestX = Math.Max(rect.Left, Math.Min(Center.X, rect.Right));
            float closestY = Math.Max(rect.Top, Math.Min(Center.Y, rect.Bottom));

            float dx = Center.X - closestX;
            float dy = Center.Y - closestY;

            return (dx * dx + dy * dy) < (Radius * Radius);
        }
    }
}
