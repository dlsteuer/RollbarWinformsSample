using System;
using System.Windows.Forms;
using RollbarDotNet;

namespace RollbarWinformsSample
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Rollbar.Init(new RollbarConfig
            {
                AccessToken = "POST_SERVER_ACCESS_TOKEN",
                Environment = "production"
            });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += (sender, args) =>
            {
                Rollbar.Report(args.Exception);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                Rollbar.Report(args.ExceptionObject as System.Exception);
            };

            Application.Run(new Form1());
        }
    }
}
