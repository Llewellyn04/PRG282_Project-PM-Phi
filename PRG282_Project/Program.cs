using System;
using System.Windows.Forms;
using System.Threading;

namespace PRG282_Project
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadingScreen loadingScreen = new LoadingScreen();
            Thread loadingThread = new Thread(() =>
            {
                loadingScreen.Show();
                for (int i = 0; i <= 100; i++)
                {
                    loadingScreen.UpdateProgress(i);
                    Thread.Sleep(30); // Simulate loading time
                }
                loadingScreen.Invoke(new Action(() => loadingScreen.Close()));
            });

            loadingThread.Start();

            Application.Run(new Form1());
        }
    }
}
