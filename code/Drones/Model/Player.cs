using System.Windows.Forms;

namespace BigNightmare
{
    // Cette partie de la classe Player définit ce qu'est un player par un modèle numérique
    public partial class Player
    {

        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        public List<Bullet> nails;
        private DateTime lastShotTime = DateTime.MinValue;
        private readonly TimeSpan shotCooldown = TimeSpan.FromMilliseconds(500); // 0,5 sec


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
            get { return new Rectangle(X, Y, 23, 50); } // largeur/hauteur du joueur
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

            // Crée une nouvelle balle au centre du joueur
            int startX = X + Hitbox.Width / 2 - 25;
            int startY = Y + Hitbox.Height / 2 - 25;

            Bullet newBullet = new Bullet(startX, startY, targetX, targetY);
            nails.Add(newBullet);
            return newBullet;
        }



        public void Move(int dx, int dy, List<Block> blocks)
        {
            // 1️⃣ Calcul de la nouvelle position du joueur
            Rectangle NextPos = new Rectangle(X + dx, Y + dy, Hitbox.Width, Hitbox.Height);

            // 2️⃣ Vérification de collision avec les blocks
            foreach (Block block in blocks)
            {
                if (block.LeftCircle.collision(NextPos) || block.RightCircle.collision(NextPos))
                {
                    return; // collision détectée
                }
            }


            // 3️⃣ Aucune collision → on applique le mouvement
            X += dx;
            Y += dy;
        }


        // Cette méthode calcule le nouvel état dans lequel le joueur se trouve après
        // que 'interval' millisecondes se sont écoulées

        public void Update(int interval)
        {

        }
    }
}
