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
        public List<Dice> ThrowDice(List<Dice> startingList, List<Dice> boardList)
        {
            Random r = new Random();
            foreach(Dice dice in startingList.ToArray())
            {
                dice.Value = r.Next(1, 7);
                boardList.Add(dice);
                startingList.Remove(dice);
            }
            return boardList;
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
