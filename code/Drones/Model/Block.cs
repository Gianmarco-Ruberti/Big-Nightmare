using System.Drawing;

namespace BigNightmare
{
    public partial class Block
    {
        private int _x;
        private int _y;
        private int rotation;

        // PV partagé pour tous les blocks
        public static int PV { get; private set; } = 15;

        public CircleHitbox LeftCircle { get; private set; }
        public CircleHitbox RightCircle { get; private set; }

        public Block(int x, int y, int rota)
        {
            _x = x;
            _y = y;
            rotation = rota;
            InitializeHitboxes();
        }

        private void InitializeHitboxes()
        {
            switch (rotation)
            {
                case 360:
                    LeftCircle = new CircleHitbox(_x + 45, _y + 75, 35);
                    RightCircle = new CircleHitbox(_x + 105, _y + 75, 35);
                    break;
                case 288:
                    LeftCircle = new CircleHitbox(_x + 65, _y + 50, 35);
                    RightCircle = new CircleHitbox(_x + 85, _y + 105, 35);
                    break;
                case 216:
                    LeftCircle = new CircleHitbox(_x + 50, _y + 95, 35);
                    RightCircle = new CircleHitbox(_x + 102, _y + 55, 35);
                    break;
                case 144:
                    LeftCircle = new CircleHitbox(_x + 50, _y + 55, 35);
                    RightCircle = new CircleHitbox(_x + 103, _y + 98, 35);
                    break;
                case 72:
                    LeftCircle = new CircleHitbox(_x + 85, _y + 45, 35);
                    RightCircle = new CircleHitbox(_x + 68, _y + 105, 35);
                    break;
            }
        }

        public static void Damage(int amount)
        {
            PV -= amount;
            if (PV < 0) PV = 0;
            Console.WriteLine($"Block PV: {PV}");
        }

        public int X { get { return _x; } set { _x = value; UpdateHitboxes(); } }
        public int Y { get { return _y; } set { _y = value; UpdateHitboxes(); } }

        private void UpdateHitboxes()
        {
            if (LeftCircle == null || RightCircle == null) return;

            switch (rotation)
            {
                case 360:
                    LeftCircle.Center = new PointF(_x + 45, _y + 75);
                    RightCircle.Center = new PointF(_x + 105, _y + 75);
                    break;
                case 288:
                    LeftCircle.Center = new PointF(_x + 65, _y + 50);
                    RightCircle.Center = new PointF(_x + 85, _y + 105);
                    break;
                case 216:
                    LeftCircle.Center = new PointF(_x + 50, _y + 95);
                    RightCircle.Center = new PointF(_x + 102, _y + 55);
                    break;
                case 144:
                    LeftCircle.Center = new PointF(_x + 50, _y + 55);
                    RightCircle.Center = new PointF(_x + 103, _y + 98);
                    break;
                case 72:
                    LeftCircle.Center = new PointF(_x + 85, _y + 45);
                    RightCircle.Center = new PointF(_x + 68, _y + 105);
                    break;
            }
        }
    }
}
