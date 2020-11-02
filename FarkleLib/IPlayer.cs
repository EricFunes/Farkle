using System;
using System.Collections.Generic;
using System.Text;

namespace FarkleLib
{
    public interface IPlayer
    {
        string Name { get; set; }
        int Score { get; set; }

        List<Dice> ThrowDice(List<Dice> remainingDices, List<Dice> diceTrack);

        string ToString();
    }
}
