using System.Xml.Linq;

namespace BigNightmare
{
    // La classe AirSpace repr�sente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fen�tre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class PlayZone : Form
    {
        public static readonly int WIDTH = 1200;        // Dimensions of the airspace
        public static readonly int HEIGHT = 600;
        private int _x;                                 // Position en X depuis la gauche de l'espace a�rien
        private int _y;
        private Player _player;

        // La flotte est l'ensemble des drones qui �voluent dans notre espace a�rien

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;

        // Initialisation de l'espace a�rien avec un certain nombre de drones
        public PlayZone(Player player)
        {
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this._player = player;
            this.KeyPreview = true; // Ensures the form captures key events before child controls
            this.KeyDown += Form1_KeyDown;
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            airspace.Graphics.Clear(Color.AliceBlue);

            // draw drones
            _player.Render(airspace);

            airspace.Render();
        }

        // Calcul du nouvel �tat apr�s que 'interval' millisecondes se sont �coul�es
        private void Update(int interval)
        {
                _player.Update(interval);
        }

        // M�thode appel�e � chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.W:
                    Console.WriteLine("W key pressed");
                    _player.Y -= 4;
                    break;
                case Keys.A:
                    Console.WriteLine("A key pressed");
                    _player.X -= 4;
                    break;
                case Keys.S:
                    Console.WriteLine("S key pressed");
                    _player.Y += 4;
                    break;
                case Keys.D:
                    Console.WriteLine(" key pressed");
                    _player.X += 4;
                    break;
            }
        }
    }
}