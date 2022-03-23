using Serilog;
using System;
using System.Windows.Forms;

namespace MediaBazaar
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
                .WriteTo.Console()
                .MinimumLevel.Debug()
                .CreateLogger();

            Application.Run(new LoginForm());
            Log.Information("app close");
            Log.CloseAndFlush();
        }
    }
}