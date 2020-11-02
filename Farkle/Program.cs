﻿using Farkle.Presenter;
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
            //Application.Run(new PlayerForm());
            //List<Player> playerList = new List<Player>();
            //playerList.Add(new Player("John"));
            //var game = new Game(playerList);
            var gameForm = new GameForm();
            //GamePresenter presenter = new GamePresenter(game, gameForm);
            Application.Run(gameForm);
          
            var pl = new List<IPlayer>(); 
            var f = new PlayerForm();
            var presenter = new PlayerPresenter(pl, f);
            Application.Run(f);
        }
    }
}
