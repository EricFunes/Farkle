using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Farkle.View
{
    public interface IPlayerForm
    {
        event EventHandler BtnPlay, BtnSave, Load;
        event FormClosingEventHandler FormClosing;
        event CancelEventHandler NameValidating;
        event EventHandler NameValidated;
        void ValidateName(object sender, CancelEventArgs e);
        void ClearErrorMessage();
    }
}
