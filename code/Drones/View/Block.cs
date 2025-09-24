using BigNightmare.Helpers;
using Drones.Properties;
using System.Drawing.Drawing2D;
using System.Numerics;
using System.Resources;
using System.Security.Cryptography.Xml;

namespace BigNightmare
{
    public partial class Block
    {
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        //rotation inspiré de https://stackoverflow.com/questions/2163829/how-do-i-rotate-a-picture-in-winforms
        public void Render(BufferedGraphics drawingSpace, float rotationAngle, Image img)
        {
                //create an empty Bitmap image
                Bitmap bmp = new Bitmap(img.Width, img.Height);

                //turn the Bitmap into a Graphics object
                Graphics gfx = Graphics.FromImage(bmp);

                //now we set the rotation point to the center of our image
                gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

                //now rotate the image
                gfx.RotateTransform(rotationAngle);

                gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

                //set the InterpolationMode to HighQualityBicubic so to ensure a high
                //quality image once it is transformed to the specified size
                gfx.InterpolationMode = InterpolationMode.HighQualityBicubic;

                gfx.DrawImage(img, new Point(0, 0));

                drawingSpace.Graphics.DrawImage(bmp, X, Y, 125, 70);
                
        }
    }
}
