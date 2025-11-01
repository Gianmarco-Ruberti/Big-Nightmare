using System.Threading.Tasks.Dataflow;
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
        private List<MobRed> _mobRed;
        private List<MobYellow> _mobYellow;
        public float rotationAngle;
        private int score = 0;
        private DateTime lastScoreIncrease = DateTime.Now;
        private Font scoreFont = new Font("Arial", 24, FontStyle.Bold);
        private SolidBrush scoreBrush = new SolidBrush(Color.White);

        BufferedGraphicsContext currentContext;
        BufferedGraphics playzone;

        // Initialisation de la zone de jeux
        public PlayZone(Player player, List<Block> block, List<Bullet> bullet, List<MobRed> mobRed, List<MobYellow> mobYellow)
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
            this._mobRed = mobRed;
            this._mobYellow = mobYellow;
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
            foreach (MobRed mobRed in _mobRed)
            {
                        mobRed.Render(playzone);
            }
            foreach (MobYellow mobYellow in _mobYellow)
            {
                mobYellow.Render(playzone);
            }

            string scoreText = $"Score : {score}";
            SizeF textSize = playzone.Graphics.MeasureString(scoreText, scoreFont);
            float x = this.ClientSize.Width - textSize.Width - 20;
            float y = 20;
            playzone.Graphics.DrawString(scoreText, scoreFont, scoreBrush, x, y);

            playzone.Render();
        }

        // Calcul du nouvel �tat apr�s que 'interval' millisecondes se sont �coul�es
        private void Update(int interval)
        {
                _player.Update(interval);
            // Met � jour les balles
            foreach (var bullet in _bullet.ToList())
            {
                bullet.Update(interval);

                // Supprime la balle si elle sort de l'�cran
                if (bullet.Y + 50 < 0) // 50 = hauteur de la balle
                    _bullet.Remove(bullet);
            }
            foreach (MobRed mobRed in _mobRed)
            {
                mobRed.Update(interval, _player, _mobRed, new List<MobMort>(), _block);
            }
            foreach (MobYellow mobYellow in _mobYellow.ToList())
            {
                mobYellow.Update(interval, _player, _bullet, _mobYellow, new List<MobMort>());
            }

            if ((DateTime.Now - lastScoreIncrease).TotalSeconds >= 5)
            {
                score += 10; // ou +1 si tu veux plus lentement
                lastScoreIncrease = DateTime.Now;
            }
        }

        // M�thode appel�e � chaque frame
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