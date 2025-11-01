using System.Windows.Forms;
using System.Collections.Generic;

namespace BigNightmare
{
    // Cette partie de la classe Player définit ce qu'est un player par un modèle numérique
    public partial class Player
    {

        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        public List<Bullet> nails;
        private DateTime lastShotTime = DateTime.MinValue;
        private readonly TimeSpan shotCooldown = TimeSpan.FromMilliseconds(500);
        public int PV { get; private set; } = 1;


        // Constructeur
        public Player(int x, int y)
        {
            _x = x;
            _y = y;
            nails = new List<Bullet>();
        }
        public int X { get { return _x;} set { _x = value; } }
        public int Y { get { return _y;} set { _y = value; } }

        public Rectangle Hitbox
        {
            get { return new Rectangle(X, Y, 23, 50); }
        }

        public void munition(Bullet bullet)
        {
            this.nails.Add(bullet);
        }

        public Bullet Shoot(int targetX, int targetY)
        {
            if (DateTime.Now - lastShotTime < shotCooldown)
                return null;

            lastShotTime = DateTime.Now;

            int startX = X + Hitbox.Width / 2 - 25;
            int startY = Y + Hitbox.Height / 2 - 25;

            Bullet newBullet = new Bullet(startX, startY, targetX, targetY);
            nails.Add(newBullet);
            return newBullet;
        }



        public void Move(int dx, int dy, List<Block> blocks)
        {
            Rectangle NextPos = new Rectangle(X + dx, Y + dy, Hitbox.Width, Hitbox.Height);

            foreach (Block block in blocks)
            {
                if (block.LeftCircle.collision(NextPos) || block.RightCircle.collision(NextPos))
                {
                    return;
                }
            }

            X += dx;
            Y += dy;
        }

        public void Damage(int amount)
        {
            PV -= amount;
            if (PV < 0) PV = 0;
        }
        // Cette méthode calcule le nouvel état dans lequel le joueur se trouve après
        // que 'interval' millisecondes se sont écoulées

        public void Update(int interval)
        {

        }
    }
}
