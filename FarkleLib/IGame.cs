using FarkleLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farkle
{
    public interface IGame
    {
        List<Dice> StartingList { get; set; }
        List<Dice> BoardList { get; set; }
        List<Dice> EndList { get; set; }
        List<Dice> ThrowDices();
        bool Verification(List<Dice> list);
    }
}