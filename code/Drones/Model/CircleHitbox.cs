using System.Drawing;

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

        // Vérifie si un rectangle touche ce cercle
        public bool collision(Rectangle rect)
        {
            float nearestX = Math.Max(rect.Left, Math.Min(Center.X, rect.Right));
            float nearestY = Math.Max(rect.Top, Math.Min(Center.Y, rect.Bottom));
            float dx = Center.X - nearestX;
            float dy = Center.Y - nearestY;
            return (dx * dx + dy * dy) <= (Radius * Radius);
        }
    }
}
