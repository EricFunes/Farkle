using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FarkleLib
{
    public interface IPlayer: INotifyPropertyChanged
    {
        string Name { get; set; }
        int Score { get; set; }

        void ThrowDice(List<Dice> remainingDices, List<Dice> diceTrack);

        string ToString();
    }
}
