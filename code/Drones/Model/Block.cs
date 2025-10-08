using System.Windows.Forms;

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
    }
}
