using BigNightmare.Helpers;
using BigNightmare.Properties;
using System.Resources;

namespace BigNightmare
{
    // Cette partie de la classe Drone définit comment on peut voir un drone

    public partial class Player
    {
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            if (false)
            {
                drawingSpace.Graphics.DrawImage(Resources.joueur_gauche, X, Y, 50, 50);
            }
            else 
            {
                drawingSpace.Graphics.DrawImage(Resources.joueur_gauche, X, Y, 23, 50);
            }
            // === DEBUG : Affiche la hitbox du joueur ===
#if DEBUG
            using (Pen hitboxPen = new Pen(Color.LimeGreen, 2))
            {
                drawingSpace.Graphics.DrawRectangle(hitboxPen, Hitbox);
            }
#endif

        }
    }
}
