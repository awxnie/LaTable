namespace LaTable
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //UserService users = new UserService();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Directory.CreateDirectory("Data");
            File.WriteAllText("Data/userDates.json", "[]");
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm());
        }
    }
}