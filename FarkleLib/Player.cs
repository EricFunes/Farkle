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
