namespace LaTable
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthForm());
            //Application.Run(new AdminForm());
            /*User user = new User("Тестик", "test", "123");
            Application.Run(new UserForm(user));*/
        }
    }
}