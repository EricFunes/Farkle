using Farkle.View;
using FarkleLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farkle.Presenter
{
    public class GamePresenter
    {
        private readonly IGame game;
        private readonly IGameForm gameForm;
        private List<Dice> list;

        public GamePresenter(IGame game, IGameForm gameForm)
        {
            this.game = game;
            this.gameForm = gameForm;

            //gameForm.FormClosing += Save;
            //gameForm.Load += Read;

            //gameForm.BtnRollDice += btnThrowDice_Click;
            //gameForm.BtnRollDice += btnSelectDice_Click;

            //gameForm.ImgDice1 += imgDice1_Click;

            //gameForm.ShowName(game.PlayerList[0].Name);
            /*List<Binding> bindStartingList = new List<Binding>();
            List<Binding> bindBoardList = new List<Binding>();
            List<Binding> bindEndList = new List<Binding>();
            for (int i = 0; i < 6; i++)
            {
                bindStartingList.Add(new Binding("Text", game, $"startingList[{i}].Value"));
                bindBoardList.Add(new Binding("Text", game, $"boardList[{i}].Value"));
                bindEndList.Add(new Binding("Text", game, $"endList[{i}].Value"));
            }*/
            //gameForm.Bind(new Binding("Text", game, "startingList"), new Binding("Text", game, "boardList"), new Binding("Text", game, "endList"));
        }

        private void Read(object sender, EventArgs e)
        {
        }

        private void Save(object sender, FormClosingEventArgs e)
        {
        }

        private void btnThrowDice_Click(object sender, EventArgs e)
        {
            Console.WriteLine("HEY");
            game.ThrowDices();
            List<int> sl = new List<int>();
            List<int> bl = new List<int>();
            List<int> el = new List<int>();
            foreach (Dice d in game.StartingList)
                sl.Add(d.Value);
            foreach (Dice d in game.BoardList)
                bl.Add(d.Value);
            foreach (Dice d in game.EndList)
                el.Add(d.Value);

            //gameForm.ShowDice(sl, bl, el);
        }

        private void btnSelectDice_Click(object sender, EventArgs e)
        {

        }

        private void imgDice1_Click(object sender, EventArgs e)
        {
            Dice d = new Dice();
            //d.Value = gameForm.List[0];
            list.Add(d);
        }
    }
}
