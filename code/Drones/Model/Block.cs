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
        public int X { get { return _x; } set { _x = value; } }

        public int Y { get { return _y; } set { _y = value; } }
        

        public CircleHitbox LeftCircle
        {
            get; private set;           
        }

        public CircleHitbox RightCircle
        {
            get; private set;
        }

    }
}
