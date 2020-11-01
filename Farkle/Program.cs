using Farkle.Presenter;
using Farkle.View;
using FarkleLib;
using System;
using System.Windows.Forms;

namespace Farkle
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var p = new Player("Eric");
            var f = new PlayerForm();
            var presenter = new PlayerPresenter(p, f);
            Application.Run(f);
        }
    }
}
