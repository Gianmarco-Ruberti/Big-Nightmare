using BigNightmare.Helpers;
using Drones.Properties;
using System.Resources;

namespace BigNightmare
{
    public partial class Block
    {
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawImage(Resources.block_top, X, Y, 125, 75);
        }
    }
}
