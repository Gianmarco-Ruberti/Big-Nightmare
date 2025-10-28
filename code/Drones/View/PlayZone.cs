using System.Xml.Linq;
using BigNightmare.Properties;

namespace BigNightmare
{
    // La classe AirSpace représente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fenêtre) qui montre une vue 2D depuis en dessus
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
        private List<Mob> _mob;
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
            this.MouseDown += PlayZone_MouseDown;

        }

        // Affichage de la situation actuelle
        private void Render()
        {
            playzone.Graphics.Clear(Color.Gray);

            _player.Render(playzone);

            foreach (Block block in _block)
            {
                block.Render(playzone);
            }

            foreach (Bullet bullet in _bullet)
            {
                bullet.Render(playzone);
            }
            playzone.Render();
        }

        // Calcul du nouvel état après que 'interval' millisecondes se sont écoulées
        private void Update(int interval)
        {
                _player.Update(interval);
            // Met à jour les balles
            foreach (var bullet in _bullet.ToList())
            {
                bullet.Update(interval);

                // Supprime la balle si elle sort de l'écran
                if (bullet.Y + 50 < 0) // 50 = hauteur de la balle
                    _bullet.Remove(bullet);
            }
            foreach (Mob mob in _mob)
            {
                if (mob is MobYellow yellow)
                    yellow.Update(interval, _player, _bullet);
                else
                    mob.Update(interval); // MobRed ou Mob de base
            }

        }

        // Méthode appelée à chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            this.Update(ticker.Interval);
            this.Render();
        }

        private void PlayZone_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Tir vers la position de la souris
                Bullet shot = _player.Shoot(e.X, e.Y);
                if (shot != null)
                {
                    _bullet.Add(shot);
                }
            }
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
            }
        }

    }
}