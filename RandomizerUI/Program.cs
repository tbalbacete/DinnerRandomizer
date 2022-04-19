using DinnerRandomizerLibrary.DataAccess;

namespace RandomizerUI
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
            DinnerRandomizerLibrary.GlobalConfig.InitializeConnections(DatabaseType.TextFile);
            ApplicationConfiguration.Initialize();
            Application.Run(new AddRecipeForm());
        }
    }
}