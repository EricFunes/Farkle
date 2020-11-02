using FarkleLib;
using System;
using System.Collections.Generic;

namespace Farkle
{
    public class Game : IGame
    {
        public List<Dice> StartingList { get; set; }
        public List<Dice> BoardList { get; set; }
        public List<Dice> EndList { get; set; }
        private List<int> occurenceList;
        public List<Player> PlayerList { get; set; }
        private int playerNb;

        public Game(List<Player> playerList)
        {
            this.PlayerList = playerList;
            playerNb = 0;
            StartingList = new List<Dice>();
            BoardList = new List<Dice>();
            EndList = new List<Dice>();
            occurenceList = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                occurenceList.Add(0);
                StartingList.Add(new Dice());
            }
        }

        public List<Dice> ThrowDices()
        {
            BoardList = PlayerList[playerNb].ThrowDice(StartingList, BoardList);

            return BoardList;
        }

        public bool Verification(List<Dice> list)
        {
            fillOccurenceList(list);
            foreach (int a in occurenceList)
                Console.WriteLine("o "+ a);

            if (check123456())
            {
                Console.WriteLine("1 TRUE");
                changeList(list);
                return true;
            }
            else if (checkThreePairs())
            {
                Console.WriteLine("2 TRUE");
                changeList(list);
                return true;
            }
            
            bool searching = true;
            while (searching == true)
            {
                searching = checkTrio();
            }

            searching = true;
            while (searching == true)
            {
                searching = check1Or5();
            }

            foreach (int i in occurenceList)
                if (i != 0)
                    return false;
            Console.WriteLine("3 TRUE");
            return true;
        }

        private void changeList(List<Dice> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                EndList.Add(list[i]);
                BoardList.Remove(list[i]);
            }
        }

        private bool check123456()
        {
            foreach (int diceNb in occurenceList)
                if (diceNb != 1)
                    return false;
            PlayerList[playerNb].Score += 3000;

            return true;
        }

        private bool checkThreePairs()
        {
            foreach (int diceNb in occurenceList)
                if (BoardList.Count != 6 || diceNb % 2 != 0)
                    return false;
            PlayerList[playerNb].Score += 1500;
            return true;
        }

        private bool checkTrio()
        {
            for (int i = 0; i < occurenceList.Count; i++)
                if (occurenceList[i] == 3)
                {
                    occurenceList[i] -= 3;
                    PlayerList[playerNb].Score += (i + 1) * 100;
                    return true;
                }
            return false;
        }

        private bool check1Or5()
        {
            if (occurenceList[0] > 0)
            {
                occurenceList[0]--;
                PlayerList[playerNb].Score += 100;
                return true;
            }
            else if (occurenceList[4] > 0)
            {
                occurenceList[4]--;
                PlayerList[playerNb].Score += 50;
                return true;
            }
            return false;
        }

        private void fillOccurenceList(List<Dice> list)
        {
            foreach (Dice dice in list)
                occurenceList[dice.Value - 1] = occurenceList[dice.Value - 1]++;
        }
    }
}