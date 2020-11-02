using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farkle.View
{
    interface IGameForm
    {
        event EventHandler BtnRollDice, BtnSelectDice, Load;
        event FormClosingEventHandler FormClosing;
        void ShowName();
        void ShowScore();
    }
}
