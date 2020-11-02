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

        public GameForm(IPlayerForm playerForm)
        {
            InitializeComponent();
            Owner = (Form) playerForm;
            myPlayerForm = playerForm;

            loadPictureBox();
            
            //List<Player> playerList = new List<Player>();
            //playerList.Add(new Player());
            game = new Game();
            changeImages();
            diceList = new List<Dice>();
        }

        public void setPlayers(List<IPlayer> players)
        {
            game.PlayerList = players;
            changeScore();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            game.ThrowDices();
            changeImages();
            if(!game.VerificationTest(game.BoardList))
            {
                MessageBox.Show("Votre tour s'arrete !");
                game.NextPlayer();
                game.Reset();
                changeImages();
                changeScore();
                btnRoll.Enabled = true;
                btnSelection.Enabled = false;
            }
            else
            {
                btnRoll.Enabled = false;
                btnSelection.Enabled = true;
            }
        }

        private void btnSelection_Click(object sender, EventArgs e)
        {
            if (game.Verification(diceList, true))
            {
                game.Verification(diceList, false);
                diceList.Clear();
                btnRoll.Enabled = true;
                btnSelection.Enabled = false;
                if (game.EndList.Count == 6)
                    game.Reset();
                else if (game.Win())
                {
                    btnRoll.Enabled = false;
                    btnSelection.Enabled = false;
                    MessageBox.Show("Vous avez Gagné !");
                }
                changeImages();
                changeScore();
            }
        }

        private void changeScore()
        {
            lblScore.Text = $"{game.getPlayerScore()}";
            lblNom.Text = game.getPlayerName();
        }

        private void changeImages()
        {
            
            for(int i = 0; i < 6; i++) {
                startingList[i].Image = null;
                boardList[i].Image = null;
                endList[i].Image = null;
                boardList[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            for (int i = 0; i < game.StartingList.Count; i++)
                startingList[i].Image = Properties.Resources.dice0;
            for (int i = 0; i < game.BoardList.Count; i++)
                boardList[i].Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{game.BoardList[i]}");
            for (int i = 0; i < game.EndList.Count; i++)
                endList[i].Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{game.EndList[i]}");
        }

        public void ImgDice1_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[0]))
            {
                diceList.Add(game.BoardList[0]);
                boardList[0].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                diceList.Remove(game.BoardList[0]);
                boardList[0].BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
        public void ImgDice2_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[1]))
            {
                diceList.Add(game.BoardList[1]);
                boardList[1].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                diceList.Remove(game.BoardList[1]);
                boardList[1].BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
        public void ImgDice3_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[2]))
            {
                diceList.Add(game.BoardList[2]);
                boardList[2].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                diceList.Remove(game.BoardList[2]);
                boardList[2].BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
        public void ImgDice4_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[3]))
            {
                diceList.Add(game.BoardList[3]);
                boardList[3].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                diceList.Remove(game.BoardList[3]);
                boardList[3].BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }
        public void ImgDice5_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[4]))
            {
                diceList.Add(game.BoardList[4]);
                boardList[4].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                diceList.Remove(game.BoardList[4]);
                boardList[4].BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

        public void ImgDice6_Click(object sender, EventArgs e)
        {
            if (!diceList.Contains(game.BoardList[5]))
            {
                diceList.Add(game.BoardList[5]);
                boardList[5].BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
            else
            {
                diceList.Remove(game.BoardList[5]);
                boardList[5].BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
        }

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
            return new GameForm(myPlayerForm);
        }
    }
}