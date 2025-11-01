using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using BigNightmare.Properties;
using BigNightmare.Helpers;

namespace BigNightmare
{
    public partial class Block
    {
        private Pen Brush = new Pen(new SolidBrush(Color.Purple), 3);

        public void Render(BufferedGraphics drawingSpace)
        {
            if (PV <= 0)
                return;

            float opacity = (float)Block.PV / 15f;
            if (opacity < 0) opacity = 0;

            ColorMatrix cm = new ColorMatrix();
            cm.Matrix33 = opacity;
            ImageAttributes ia = new ImageAttributes();
            ia.SetColorMatrix(cm, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

            Image img = rotation switch
            {
                72 => Resources.block_5,
                144 => Resources.block_3,
                216 => Resources.block_4,
                288 => Resources.block_2,
                360 => Resources.block_1,
                _ => null
            };

            if (img != null)
            {
                drawingSpace.Graphics.DrawImage(
                    img,
                    new Rectangle(X, Y, 150, 150),
                    0, 0, img.Width, img.Height,
                    GraphicsUnit.Pixel,
                    ia
                );
            }

#if DEBUG
            // === DEBUG : Affiche la hitbox du block ===
            using (Pen pen = new Pen(Color.Red, 2))
            {
                pen.DashStyle = DashStyle.Dot;
                // Cercle gauche
                drawingSpace.Graphics.DrawEllipse(pen,
                    LeftCircle.Center.X - LeftCircle.Radius,
                    LeftCircle.Center.Y - LeftCircle.Radius,
                    LeftCircle.Radius * 2,
                    LeftCircle.Radius * 2);

                // Cercle droit
                drawingSpace.Graphics.DrawEllipse(pen,
                    RightCircle.Center.X - RightCircle.Radius,
                    RightCircle.Center.Y - RightCircle.Radius,
                    RightCircle.Radius * 2,
                    RightCircle.Radius * 2);
            }
#endif
        }
    }
}
