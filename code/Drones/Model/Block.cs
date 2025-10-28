using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace BigNightmare
{

    public partial class Block
    {
        private int _x;
        private int _y;
        private int rotation;
        public Block(int x, int y, int rota)
        {
            _x = x;
            _y = y;
            rotation = rota;
        }
        public int X { get { return _x; } set { _x = value; } }

        public int Y { get { return _y; } set { _y = value; } }
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
            public bool Intersects(Rectangle rect)
            {
                float closestX = Math.Max(rect.Left, Math.Min(Center.X, rect.Right));
                float closestY = Math.Max(rect.Top, Math.Min(Center.Y, rect.Bottom));

                float dx = Center.X - closestX;
                float dy = Center.Y - closestY;

                return (dx * dx + dy * dy) < (Radius * Radius);
            }
        }

        public CircleHitbox LeftCircle
        {
            get
            {
                if (rotation == 360)
                {
                    float cx = _x + 45; // centre du cercle gauche
                    float cy = _y + 75; // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
                else if (rotation == 288)
                {
                    float cx = _x + 65; // centre du cercle gauche
                    float cy = _y + 50; // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
                else if (rotation == 216)
                {
                    float cx = _x + 50; // centre du cercle gauche
                    float cy = _y + 95; // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
                else if (rotation == 144)
                {
                    float cx = _x + 50; // centre du cercle gauche
                    float cy = _y + 55; // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
                else
                {
                    float cx = _x + 85; // centre du cercle gauche
                    float cy = _y + 45; // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
            }
        }

        public CircleHitbox RightCircle
        {
            get
            {

                if (rotation == 360)
                {
                    float cx = _x + 105; // centre du cercle droit
                    float cy = _y + 75;       // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
                else if (rotation == 288)
                {
                    float cx = _x + 85; // centre du cercle gauche
                    float cy = _y + 105; // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
                else if (rotation == 216)
                {
                    float cx = _x + 102; // centre du cercle gauche
                    float cy = _y + 55; // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
                else if (rotation == 144)
                {
                    float cx = _x + 103; // centre du cercle gauche
                    float cy = _y + 98; // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
                else
                {
                    float cx = _x + 68; // centre du cercle gauche
                    float cy = _y + 105; // centre vertical
                    float radius = 35;
                    return new CircleHitbox(cx, cy, radius);
                }
            }
        }

    }
}
