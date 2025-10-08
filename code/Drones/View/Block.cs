using BigNightmare.Helpers;
using BigNightmare.Properties;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Resources;
using System.Security.Cryptography.Xml;

namespace BigNightmare
{
    public partial class Block
    {

        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);
        public void Render(BufferedGraphics drawingSpace)
        {
            switch (rotation)
            {
                case 72:
                    drawingSpace.Graphics.DrawImage(Resources.block_5, X, Y, 150, 150);
                    break;
                case 144:
                    drawingSpace.Graphics.DrawImage(Resources.block_3, X, Y, 150, 150);
                    break;
                case 216:
                    drawingSpace.Graphics.DrawImage(Resources.block_4, X, Y, 150, 150);
                    break;
                case 288:
                    drawingSpace.Graphics.DrawImage(Resources.block_2, X, Y, 150, 150);
                    break;
                case 360:
                    drawingSpace.Graphics.DrawImage(Resources.block_1, X, Y, 150, 150);
                    break;
                default:
                    // Par défaut, une image neutre ou rien
                    break;
            }
        }
    }
}
