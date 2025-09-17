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
    }
}
