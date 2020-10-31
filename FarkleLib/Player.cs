using System;
using System.Collections.Generic;

namespace FarkleLib
{
    public class Player: IPlayer
    {
        // Properties
        public string Name { get; set; }
        public int Score { get; set; }

        /// <summary>
        /// Player has a name and his score is set to 0.
        /// </summary>
        /// <param name="name"></param>
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

        /// <summary>
        /// The player throws the remaining dices with to the dice track.
        /// </summary>
        /// <param name="diceList"></param>
        public void ThrowDice(List<Dice> remainingDices, List<Dice> diceTrack)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Shows player's name and score.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} {Score}";
        }
    }
}
