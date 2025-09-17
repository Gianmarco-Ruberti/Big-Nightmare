using BigNightmare.Helpers;
using Drones.Properties;
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
                drawingSpace.Graphics.DrawImage(Resources.Joueur_gauche, X, Y, 50, 50);
                drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, X + 5, Y - 25);
            }
            else 
            {
                drawingSpace.Graphics.DrawImage(Resources.joueur_droite, X, Y, 50, 50);
                drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, X + 5, Y - 25);
            }
        }

        // De manière textuelle
        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
