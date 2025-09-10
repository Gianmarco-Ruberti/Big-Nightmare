namespace BigNightmare
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Cr�ation de la flotte de drones
            List<Player> fleet= new List<Player>();
            fleet.Add(new Player(PlayZone.WIDTH / 2, PlayZone.HEIGHT / 2, "Joe"));

            // D�marrage
            Application.Run(new PlayZone(fleet));
        }
    }
}