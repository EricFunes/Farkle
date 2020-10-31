using System;

namespace FarkleLib
{
    public class Dice: IDice
    {
        // Properties
        public int Value { get; set; }

        /// <summary>
        /// Shows the value of the dice.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
