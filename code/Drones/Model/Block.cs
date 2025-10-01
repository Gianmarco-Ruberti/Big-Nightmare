using System.Windows.Forms;

namespace BigNightmare
{

    public partial class Block
    {
        private int _x;
        private int _y;
        public Block(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int X { get { return _x; } set { _x = value; } }

        public int Y { get { return _y; } set { _y = value; } }

        public void RotateAroundPoint(double angleDegrees, int cx, int cy)
        {
            double angleRadians = angleDegrees * Math.PI / 180.0;

            // Translate to origin
            double translatedX = _x - cx;
            double translatedY = _y - cy;

            // Rotate
            double rotatedX = translatedX * Math.Cos(angleRadians) - translatedY * Math.Sin(angleRadians);
            double rotatedY = translatedX * Math.Sin(angleRadians) + translatedY * Math.Cos(angleRadians);

            // Translate back
            _x = (int)Math.Round(rotatedX + cx);
            _y = (int)Math.Round(rotatedY + cy);
        }
    }
}
