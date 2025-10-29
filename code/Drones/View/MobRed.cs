using System.Drawing;
using BigNightmare.Properties;

namespace BigNightmare
{
    public partial class MobRed
    {
        int frameCount = 0;
        private Pen mobBrush = new Pen(Color.Green, 2);

        public void Render(BufferedGraphics drawingSpace)
        {
            if(frameCount%3 == 0)
            {drawingSpace.Graphics.DrawImage(Resources.mob_red, (int)X, (int)Y, 75, 75);}
            else
            {drawingSpace.Graphics.DrawImage(Resources.mob_red_1, (int)X, (int)Y, 75, 75);}
            frameCount++;
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
