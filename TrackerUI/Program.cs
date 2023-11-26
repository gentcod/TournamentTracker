namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize database connection
            var database = true;
            var textDB = true;
            TrackerLibrary.GlobalConfig.InitConnections(database, textDB);

            Application.Run(new CreatePriceForm());
        }
    }
}