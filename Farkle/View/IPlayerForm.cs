using FarkleLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Farkle.View
{
    public interface IPlayerForm
    {
        event EventHandler BtnPlay, BtnAddPlayer, Load;

        event FormClosingEventHandler FormClosing;

        event CancelEventHandler NameValidatingPlayer1, NameValidatingPlayer2;

        event EventHandler NameValidatedPlayer1, NameValidatedPlayer2;

        void ValidateNamePlayer1(object sender, CancelEventArgs e);

        void ValidateNamePlayer2(object sender, CancelEventArgs e);

        void ClearErrorMessage();

        void SetP1NameDataBinding(Binding b);

        void SetP2NameDataBinding(Binding b);
        
        void ShowPlayButton();
        
        void AddPlayer(List<IPlayer> list, IPlayer p);
    }
}
