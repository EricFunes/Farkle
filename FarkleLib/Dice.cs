using System;

namespace FarkleLib
{
    public class Dice: IDice
    {
        public int Value { get; set; }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
