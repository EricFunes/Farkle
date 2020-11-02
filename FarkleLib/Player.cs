using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace FarkleLib
{
    public class Player: IPlayer, INotifyPropertyChanged
    {
        // Properties
        private string name;
        public string Name { 
            get 
            {
                return name;
            }

            set
            {
                name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));

            }
        }
        public int Score { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

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
