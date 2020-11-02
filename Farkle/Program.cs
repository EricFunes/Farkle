using Farkle.Presenter;
using Farkle.View;
using FarkleLib;
using System;
using System.Collections.Generic;
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
            var pl = new List<IPlayer>(); 
            var f = new PlayerForm();
            var gameForm = new GameForm(f, pl);
            var presenter = new PlayerPresenter(pl, f, gameForm);
            Application.Run(f);
        }
    }
}
