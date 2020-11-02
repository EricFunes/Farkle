using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farkle.View
{
    public interface IGameForm
    {
        List<int> List { get; set; }
        event EventHandler BtnRollDice, BtnSelectDice, Load, ImgDice1;
        event FormClosingEventHandler FormClosing;
        void ShowDice(List<int> intStartingList, List<int> intBoardList, List<int> intEndList);
        void ShowName(string name);
        void ShowScore(int score);
    }
}
