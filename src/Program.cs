using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace MyApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Task.Run(async () =>
            {
                using (var mgr = await UpdateManager.GitHubUpdateManager("https://github.com/distantcam/SquirrelTest"))
                {
                    var updateInfo = await mgr.CheckForUpdate();
                }
            });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}