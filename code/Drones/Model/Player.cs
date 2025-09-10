namespace BigNightmare
{
    // Cette partie de la classe Drone définit ce qu'est un drone par un modèle numérique
    public partial class Player
    {
        public static readonly int FULLCHARGE = 1000;   // Charge maximale de la batterie
        private int _charge;                            // La charge actuelle de la batterie
        private string _name;                           // Un nom
        private int _x;                                 // Position en X depuis la gauche de l'espace aérien
        private int _y;                                 // Position en Y depuis le haut de l'espace aérien

        // Constructeur
        public Player(int x, int y, string name)
        {
            _x = x;
            _y = y;
            _name = name;
            _charge = GlobalHelpers.alea.Next(FULLCHARGE); // La charge initiale de la batterie est choisie aléatoirement
        }
        public int X { get { return _x;} }
        public int Y { get { return _y;} }
        public string Name { get { return _name;} }

        // Cette méthode calcule le nouvel état dans lequel le drone se trouve après
        // que 'interval' millisecondes se sont écoulées
        public void Update(int interval)
        {
            ConsoleKeyInfo keyPressed;
            Console.Clear();
            if (Console.KeyAvailable)
            {
                keyPressed = Console.ReadKey(false);
                switch (keyPressed.Key)
                {
                    case ConsoleKey.W:
                        _y += 4;
                        break;

                    case ConsoleKey.A:
                        _x -= 4;
                        break;
                    case ConsoleKey.S:
                        _y -= 4;
                        break;

                    case ConsoleKey.D:
                        _x += 4;
                        break;
                }
            }
        }                                 
    }
}
