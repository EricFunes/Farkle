using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FarkleLib
{
    class DiceList : IEnumerable<Dice>
    {
        public List<Dice> ListDice { get; set; }

        public DiceList()
        {
            this.ListDice = new List<Dice>();
        }

        public void Add(Dice dice)
        {
            ListDice.Add(dice);
        }

        public IEnumerator<Dice> GetEnumerator()
        {
            return ListDice.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
}
