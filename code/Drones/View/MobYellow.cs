using BigNightmare.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigNightmare
{
    public partial class MobYellow
    {
        int frameCount = 0;
        private Pen mobBrush = new Pen(Color.Green, 2);

        public void Render(BufferedGraphics drawingSpace)
        {
            if (frameCount % 3 == 0)
            { drawingSpace.Graphics.DrawImage(Resources.mob_yellow, (int)X, (int)Y, 90, 90); }
            else
            { drawingSpace.Graphics.DrawImage(Resources.mob_yellow_1, (int)X, (int)Y, 90, 90); }
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
