using System.Xml.Linq;
using BigNightmare.Properties;

namespace BigNightmare
{
    // La classe AirSpace repr�sente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fen�tre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class PlayZone : Form
    {
        public static readonly int WIDTH = 1920;        // Dimensions of the playzone
        public static readonly int HEIGHT = 1080;
        private int _x;                                 // Position en X depuis la gauche de la playzone
        private int _y;
        private Player _player;
        private List<Block> _block;
        private List<Bullet> _bullet;
        public float rotationAngle;

        BufferedGraphicsContext currentContext;
        BufferedGraphics playzone;

        // Initialisation de la zone de jeux
        public PlayZone(Player player, List<Block> block, List<Bullet> bullet)
        {
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            playzone = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this._player = player;
            this._block = block;
            this._bullet = bullet;
            this.KeyPreview = true; // Ensures the form captures key events before child controls
            this.KeyDown += Form1_KeyDown;
        }

        // Affichage de la situation actuelle
        private void Render()
        {
            playzone.Graphics.Clear(Color.Gray);

            // draw drones
            _player.Render(playzone);

            foreach (Block block in _block)
            {
                block.Render(playzone);
            }
            playzone.Render();
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

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.W:
                    Console.WriteLine("w");
                    _player.Move(0, -4, _block);
                    break;
                case Keys.A:
                    _player.Move(-4, 0, _block);
                    break;
                case Keys.S:
                    _player.Move(0, 4, _block);
                    break;
                case Keys.D:
                    _player.Move(4, 0, _block);
                    break;
                case Keys.LButton:
                    Console.WriteLine("Shot");
                    break;
            }
        }

    }
}