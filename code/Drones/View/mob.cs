using System.Drawing;
using BigNightmare.Properties;

namespace BigNightmare
{
    public partial class Mob
    {
        private Pen mobBrush = new Pen(Color.Green, 2);

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawImage(Resources.mob_red, (int)X, (int)Y, 50, 50);

#if DEBUG
            // Hitbox en pointillés pour debug
            using (Pen pen = new Pen(Color.Red, 2))
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                drawingSpace.Graphics.DrawRectangle(pen, Hitbox);
            }
#endif
        }
    }
}
