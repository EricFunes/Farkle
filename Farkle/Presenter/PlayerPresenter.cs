using Farkle.View;
using FarkleLib;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Farkle.Presenter
{
    public class PlayerPresenter
    {
        private readonly IPlayer myPlayer;
        private readonly IPlayerForm myPlayerForm;

        /// <summary>
        /// Creates a player and the player form;
        /// </summary>
        /// <param name="player"></param>
        /// <param name="form"></param>
        public PlayerPresenter(IPlayer player, IPlayerForm form)
        {
            myPlayer = player;
            myPlayerForm = form;

            myPlayerForm.BtnPlay += MyPlayerForm_BtnPlay;
            myPlayerForm.BtnSave += MyPlayerForm_BtnSave;
            myPlayerForm.Load += MyPlayerForm_Load;
            myPlayerForm.FormClosing += MyPlayerForm_FormClosing;
            myPlayerForm.NameValidating += MyPlayerForm_NameValidating;
            myPlayerForm.NameValidated += ClearMessage;
        }

        private void ClearMessage(object sender, EventArgs e)
        {
            myPlayerForm.ClearErrorMessage();
        }

        private void MyPlayerForm_NameValidating(object sender, CancelEventArgs e)
        {
            myPlayerForm.ValidateName(sender, e);
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
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Save button event of the form. Adds the player name to the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPlayerForm_BtnSave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Play button event. Starts the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPlayerForm_BtnPlay(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
