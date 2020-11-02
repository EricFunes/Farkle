using FarkleLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farkle.View
{
    public partial class GameForm : Form, IGameForm
    {
        public List<Dice> diceList;
        private List<System.Windows.Forms.PictureBox> startingList, boardList, endList;
        private Game game;
        private IPlayerForm myPlayerForm;
        private List<IPlayer> myPlayerList;

        public GameForm(IPlayerForm playerForm, List<IPlayer> players)
        {
            InitializeComponent();
            Owner = (Form) playerForm;
            myPlayerList = players;
            myPlayerForm = playerForm;

            loadPictureBox();
            
            List<Player> playerList = new List<Player>();
            playerList.Add(new Player());
            game = new Game(playerList);
            for (int i = 0; i < 6; i++)
                endList[i].Image = Properties.Resources.dice0;

            diceList = new List<Dice>();

            //this.ImgDice1 += ImgDice1_Click;
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            List<Dice> list = game.ThrowDices();
            for(int i = 0; i < list.Count; i++)
                boardList[i].Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{list[i]}");
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            foreach(Dice d in diceList)
            Console.WriteLine(d.ToString());
            //Console.WriteLine(game.Verification(diceList));
            if(game.Verification(diceList))
                for (int i = 0; i < game.EndList.Count; i++)
                    endList[i].Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{game.EndList[i]}");
        }

        /*event EventHandler ImgDice1
        {
            add { boardList[0].Click += value; }
            remove { boardList[0].Click -= value; }
        }*/

        public void ImgDice1_Click(object sender, EventArgs e)
        {
            if(!diceList.Contains(game.BoardList[0]))
                diceList.Add(game.BoardList[0]);
            else
                diceList.Remove(game.BoardList[0]);
        }
        public void ImgDice2_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[1]))
                diceList.Add(game.BoardList[1]);
            else
                diceList.Remove(game.BoardList[1]);
        }
        public void ImgDice3_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[2]))
                diceList.Add(game.BoardList[2]);
            else
                diceList.Remove(game.BoardList[2]);
        }
        public void ImgDice4_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[3]))
                diceList.Add(game.BoardList[3]);
            else
                diceList.Remove(game.BoardList[3]);
        }
        public void ImgDice5_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[4]))
                diceList.Add(game.BoardList[4]);
            else
                diceList.Remove(game.BoardList[4]);
        }

        public void ImgDice6_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[5]))
                diceList.Add(game.BoardList[5]);
            else
                diceList.Remove(game.BoardList[5]);
        }

        /*public event EventHandler BtnRollDice
        {
            add { btnRoll.Click += value; }
            remove { btnRoll.Click -= value; }
        }

        public event EventHandler BtnSelectDice
        {
            add { btnSelection.Click += value; }
            remove { btnSelection.Click -= value; }
        }

        public event EventHandler ImgDice1
        {
            add {
                List.Add(Int32.Parse($"{boardList[0].Tag.ToString().Last()}"));
                boardList[0].Click += value; }
            remove {
                List.Remove(boardList[0].Tag.ToString().Last());
                boardList[0].Click -= value; }
        }

        public void ShowDice(List<int> intStartingList, List<int> intBoardList, List<int> intEndList)
        {
            for(int i = 0; i < intStartingList.Count; i++)
            {
                startingList[i].Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{intStartingList[i]}");
                startingList[i].Tag = $"dice{intStartingList[i]}";
            }
                
            for (int i = 0; i < intBoardList.Count; i++)
            {
                boardList[i].Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{intBoardList[i]}");
                boardList[i].Tag = $"dice{intBoardList[i]}";
            }
            
            for (int i = 0; i < intEndList.Count; i++)
            {
                endList[i].Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{intEndList[i]}");
                endList[i].Tag = $"dice{intEndList[i]}";
            }
            
        }

        public void ShowName(string name)
        {
            lblNom.Text = name;
        }

        public void ShowScore(int score)
        {
            lblScore.Text = $"{score}";
        }*/

        private void loadPictureBox()
        {
            startingList = new List<System.Windows.Forms.PictureBox>();
            boardList = new List<System.Windows.Forms.PictureBox>();
            endList = new List<System.Windows.Forms.PictureBox>();
            for (int i = 0; i < 6; i++)
            {
                this.startingList.Add(new System.Windows.Forms.PictureBox());
                this.boardList.Add(new System.Windows.Forms.PictureBox());
                this.endList.Add(new System.Windows.Forms.PictureBox());
            }
            // 
            // startingList
            // 
            int location = 12;
            for (int i = 0; i < 6; i++)
            {
                this.startingList[i].Location = new System.Drawing.Point(12, location + (i * 56));
                this.startingList[i].Name = $"staringList{i}";
                this.startingList[i].Size = new System.Drawing.Size(50, 50);
                this.startingList[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.startingList[i].TabIndex = i + 1;
                this.startingList[i].TabStop = false;
            }
            // 
            // boardList
            // 
            int[] x = { 132, 211, 254, 188, 158, 281 };
            int[] y = { 111, 49, 126, 150, 218, 192 };
            for (int i = 0; i < 6; i++)
            {
                this.boardList[i].Location = new System.Drawing.Point(x[i], y[i]);
                this.boardList[i].Name = $"boardList{i}";
                this.boardList[i].Size = new System.Drawing.Size(50, 50);
                this.boardList[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.boardList[i].TabIndex = i + 7;
                this.boardList[i].TabStop = false;
            }
            // 
            // endList
            // 
            location = 406;
            for (int i = 0; i < 6; i++)
            {
                this.endList[i].Location = new System.Drawing.Point(406, location + (i * 56));
                this.endList[i].Name = $"endList{i}";
                this.endList[i].Size = new System.Drawing.Size(50, 50);
                this.endList[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                this.endList[i].TabIndex = i + 13;
                this.endList[i].TabStop = false;
            }
            this.boardList[0].Click += new System.EventHandler(this.ImgDice1_Click);
            this.boardList[1].Click += new System.EventHandler(this.ImgDice2_Click);
            this.boardList[2].Click += new System.EventHandler(this.ImgDice3_Click);
            this.boardList[3].Click += new System.EventHandler(this.ImgDice4_Click);
            this.boardList[4].Click += new System.EventHandler(this.ImgDice5_Click);
            this.boardList[5].Click += new System.EventHandler(this.ImgDice6_Click);
            for (int i = 0; i < 6; i++)
            {
                this.Controls.Add(this.startingList[i]);
                this.Controls.Add(this.boardList[i]);
                this.Controls.Add(this.endList[i]);
            }
        }
        public IGameForm CreateNewInstance()
        {
            return new GameForm(myPlayerForm, myPlayerList);
        }
    }
}