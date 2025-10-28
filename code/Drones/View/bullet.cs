using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BigNightmare.Properties;

namespace BigNightmare
{
    // dimention de bullet = 13, 50
    public partial class Bullet
    {
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            Graphics g = drawingSpace.Graphics;
            g.TranslateTransform(bx + 25, by + 25); // centre de l'image
            g.RotateTransform(angle);               // rotation
            g.DrawImage(Resources.player_Bullet, -25, -25, 13, 50); // dessine centrée
            g.ResetTransform();                     // remet la transformation
        }

    }
}
