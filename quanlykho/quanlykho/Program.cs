using quanlykho.Utils;

namespace quanlykho
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBhelper.serverName = "WIZH\\SQLEXPRESS";
            DBhelper.dbName = "quanlykho";
            DBhelper.userDb = "Minh";
            DBhelper.password = "123";
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MDI());
        }
    }
}