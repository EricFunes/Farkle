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
        private List<System.Windows.Forms.PictureBox> startingList, boardList, endList;
        private Game game;

        public event EventHandler ButonClickRoll;

        public GameForm()
        {
            InitializeComponent();
            loadPictureBox();

            game = new Game();
            for (int i = 0; i < 6; i++)
                endList[i].Image = Properties.Resources.dice0;
        }

        public void Play()
        {
            List<Dice> list = game.ThrowDices();
            for (int i = 0; i < 6; i++)
            {
                boardList[i].Image = (Image)Properties.Resources.ResourceManager.GetObject($"dice{list[i]}");
                //Console.WriteLine(list[i]);
            }

            //object obj = ResourceManager.GetObject($"dice{list[0]}");

        }

        public event EventHandler BtnRollDice
        {
            add { btnRoll.Click += value; }
            remove { btnRoll.Click -= value; }
        }

        public event EventHandler BtnSelectDice
        {
            add { btnSelection.Click += value; }
            remove { btnSelection.Click -= value; }
        }

        public void Bind(List<Binding> bindStartingList, List<Binding> bindBoardList, List<Binding> bindEndList)
        {
            //bindList = new BindingList<Dice>();
            //bindList.Add(starting);
            //startingList[0].DataBindings.Add(new Binding("Text", Game, "startingList[0]"));
            for(int i = 0; i < 6; i++)
            {
                startingList[i].DataBindings.Add(bindStartingList[i]);
                boardList[i].DataBindings.Add(bindBoardList[i]);
                endList[i].DataBindings.Add(bindEndList[i]);
            }
        }

        public void ShowName()
        {

        }

        public void ShowScore()
        {

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
            for (int i = 0; i < 6; i++)
            {
                this.Controls.Add(this.startingList[i]);
                this.Controls.Add(this.boardList[i]);
                this.Controls.Add(this.endList[i]);
            }
        }
    }
}