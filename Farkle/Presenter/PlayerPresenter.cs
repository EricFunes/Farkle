using Farkle.View;
using FarkleLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Farkle.Presenter
{
    public class PlayerPresenter
    {
        private IPlayer player1;
        private IPlayer player2;
        private List<IPlayer> playerList;
        private readonly IPlayerForm myPlayerForm;
        private IGameForm myGameForm;

        /// <summary>
        /// Creates a player and the player form.
        /// </summary>
        /// <param name="players"></param>
        /// <param name="playerForm"></param>
        public PlayerPresenter(List<IPlayer> players, IPlayerForm playerForm, IGameForm gameForm)
        {
            player1 = new Player();
            player2 = new Player();
            myPlayerForm = playerForm;
            playerList = players;
            myGameForm = gameForm;

            myPlayerForm.BtnPlay += MyPlayerForm_BtnPlay;
            myPlayerForm.BtnAddPlayer += MyPlayerForm_BtnAddPlayer;

            //myPlayerForm.Load += MyPlayerForm_Load;
            myPlayerForm.FormClosing += MyPlayerForm_FormClosing;

            myPlayerForm.NameValidatingPlayer1 += ValidateNamePlayer1;
            myPlayerForm.NameValidatingPlayer2 += ValidateNamePlayer2;

            myPlayerForm.NameValidatedPlayer1 += ClearMessage;
            myPlayerForm.NameValidatedPlayer2 += ClearMessage;

            myPlayerForm.ComboLang += comboBox1_SelectedIndexChanged;

            //myPlayerForm.SetP1NameDataBinding(new Binding("Text", player1, "Name"));
            //myPlayerForm.SetP2NameDataBinding(new Binding("Text", player2, "Name"));
        }

        /// <summary>
        /// Clears ErrorProvider.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearMessage(object sender, EventArgs e)
        {
            myPlayerForm.ClearErrorMessage();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValidateNamePlayer1(object sender, CancelEventArgs e)
        {
            myPlayerForm.ValidateNamePlayer1(sender, e);
        }

        private void ValidateNamePlayer2(object sender, CancelEventArgs e)
        {
            myPlayerForm.ValidateNamePlayer2(sender, e);
        }

        /// <summary>
        /// When the form closes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPlayerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        /// <summary>
        /// When the form loads.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPlayerForm_Load(object sender, EventArgs e)
        {
            myPlayerForm.AddLangCombo("Français");
            myPlayerForm.AddLangCombo("English");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr");

            myPlayerForm.BtnPlay += MyPlayerForm_BtnPlay;
            myPlayerForm.BtnAddPlayer += MyPlayerForm_BtnAddPlayer;

            //myPlayerForm.Load += MyPlayerForm_Load;
            myPlayerForm.FormClosing += MyPlayerForm_FormClosing;

            myPlayerForm.NameValidatingPlayer1 += ValidateNamePlayer1;
            myPlayerForm.NameValidatingPlayer2 += ValidateNamePlayer2;

            myPlayerForm.NameValidatedPlayer1 += ClearMessage;
            myPlayerForm.NameValidatedPlayer2 += ClearMessage;

            myPlayerForm.ComboLang += comboBox1_SelectedIndexChanged;

            myPlayerForm.SetP1NameDataBinding(new Binding("Text", player1, "Name"));
            myPlayerForm.SetP2NameDataBinding(new Binding("Text", player2, "Name"));
        }

        /// <summary>
        /// Save button event of the form. Adds the player name to the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPlayerForm_BtnAddPlayer(object sender, EventArgs e)
        {
            myPlayerForm.AddPlayer(playerList, player1);
            myPlayerForm.AddPlayer(playerList, player2);
            myPlayerForm.ShowPlayButton();
        }

        /// <summary>
        /// Play button event. Starts the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPlayerForm_BtnPlay(object sender, EventArgs e)
        {
            if (myGameForm.IsDisposed)
            {
                myGameForm = myGameForm.CreateNewInstance();
            }
            myGameForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myPlayerForm.ChangeLang();
            MyPlayerForm_Load(sender, e);
        }
    }
}
