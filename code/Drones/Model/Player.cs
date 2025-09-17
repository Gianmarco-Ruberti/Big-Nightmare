namespace BigNightmare
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Player
    {

        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien

        // Constructeur
        public Player(int x, int y)
        {
            _x = x;
            _y = y;
        }
        public int X { get { return _x;} set { _x = value; } }
        public int Y { get { return _y;} set { _y = value; } }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées

        public void Update(int interval)
        {
        }
    }
}
