namespace BigNightmare
{
    // Cette partie de la classe Player définit ce qu'est un player par un modèle numérique
    public partial class Player
    {

        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien
        public List<Bullet> nails;

        // Constructeur
        public Player(int x, int y)
        {
            _x = x;
            _y = y;
            nails = new List<Bullet>();
        }
        public int X { get { return _x;} set { _x = value; } }
        public int Y { get { return _y;} set { _y = value; } }

        public void munition(Bullet bullet)
        {
            this.nails.Add(bullet);
        }

        public Bullet shot()
        {
            Bullet nail = nails.First();
            nail.bx = _x;
            nail.by= this._y;
            return nail;
        }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées

        public void Update(int interval)
        {

        }
    }
}
