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

        private Pen Brush = new Pen(new SolidBrush(Color.Purple), 3);
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
            // === DEBUG : Affiche la hitbox du block ===
#if DEBUG
            using (Pen pen = new Pen(Color.Red, 2))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                // Cercle gauche
                drawingSpace.Graphics.DrawEllipse(pen, LeftCircle.Center.X - LeftCircle.Radius,
                                                         LeftCircle.Center.Y - LeftCircle.Radius,
                                                         LeftCircle.Radius * 2,
                                                         LeftCircle.Radius * 2);
                // Cercle droit
                drawingSpace.Graphics.DrawEllipse(pen, RightCircle.Center.X - RightCircle.Radius,
                                                         RightCircle.Center.Y - RightCircle.Radius,
                                                         RightCircle.Radius * 2,
                                                         RightCircle.Radius * 2);
            }
#endif


        }
    }
}
