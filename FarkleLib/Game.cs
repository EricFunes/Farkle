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
        public List<IPlayer> PlayerList { get; set; }
        private int playerNb;

        public Game()
        {
            playerNb = 0;
            StartingList = new List<Dice>();
            BoardList = new List<Dice>();
            EndList = new List<Dice>();
            occurenceList = new List<int>();
            Reset();
        }

        public void NextPlayer()
        {
            if (playerNb == 1)
                playerNb = 0;
            else
                playerNb++;
        }

        public int getPlayerScore()
        {
            return PlayerList[playerNb].Score;
        }

        public string getPlayerName()
        {
            return PlayerList[playerNb].Name;
        }

        public bool Win()
        {
            if (PlayerList[playerNb].Score >= 10000)
                return true;
            return false;
        }

        public void Reset()
        {
            StartingList.Clear();
            BoardList.Clear();
            EndList.Clear();
            for (int i = 0; i < 6; i++)
            {
                occurenceList.Add(0);
                StartingList.Add(new Dice());
            }
        }

        public List<Dice> ThrowDices()
        {
            BoardList = PlayerList[playerNb].ThrowDice(StartingList, BoardList);
            foreach (Dice d in StartingList.ToArray())
                StartingList.Remove(d);
            return BoardList;
        }

        public bool Verification(List<Dice> list, bool fake)
        {
            bool result = true;
            fillOccurenceList(list);

            if (check123456())
            {
                if (!fake)
                {
                    changeList(list);
                    PlayerList[playerNb].Score += 3000;
                }
                return result;
            }
            else if (checkThreePairs(list))
            {
                if (!fake)
                {
                    PlayerList[playerNb].Score += 1500;
                    changeList(list);
                }
                return result;
            }
            int searching = 0;
            while (searching >= 0)
            {
                searching = checkTrio();
                if(searching != -1 && !fake)
                    PlayerList[playerNb].Score += (searching + 1) * 100;
            }

            searching = 0;
            while (searching >= 0)
            {
                searching = check1Or5();
                if (searching == 1 && !fake)
                    PlayerList[playerNb].Score += 100;
                else if (searching == 5 && !fake)
                    PlayerList[playerNb].Score += 50;
            }


            foreach (int i in occurenceList)
                if (i != 0)
                    result = false;

            if (!fake)
                changeList(list);
            else
                for (int i = 0; i < 6; i++)
                    occurenceList[i] = 0;
            return result;
        }

        public bool VerificationTest(List<Dice> list)
        {
            bool result = false;
            fillOccurenceList(list);

            if (check123456())
                result = true;
            else if (checkThreePairs(list))
                result = true;
            else if (checkTrio() != -1)
                result = true;
            else if (check1Or5() != -1)
                result = true;

            for (int i = 0; i < 6; i++)
                occurenceList[i] = 0;
            return result;
        }

        private void changeList(List<Dice> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                EndList.Add(list[i]);
                BoardList.Remove(list[i]);
            }
            foreach (Dice d in BoardList.ToArray())
            {
                StartingList.Add(d);
                BoardList.Remove(d);
            }
        }

        private bool check123456()
        {
            foreach (int diceNb in occurenceList)
                if (diceNb != 1)
                    return false;
            for (int i = 0; i < 6; i++)
                occurenceList[i] = 0;
            return true;
        }

        private bool checkThreePairs(List<Dice> list)
        {
            foreach (int diceNb in occurenceList)
                if (list.Count != 6 || diceNb % 2 != 0)
                    return false;
            for (int i = 0; i < 6; i++)
                occurenceList[i] = 0;
            return true;
        }

        private int checkTrio()
        {
            for (int i = 0; i < occurenceList.Count; i++)
                if (occurenceList[i] == 3)
                {
                    occurenceList[i] -= 3;
                    return i;
                }
            return -1;
        }

        private int check1Or5()
        {
            if (occurenceList[0] > 0)
            {
                occurenceList[0]--;
                return 1;
            }
            else if (occurenceList[4] > 0)
            {
                occurenceList[4]--;
                return 5;
            }
            return -1;
        }

        private void fillOccurenceList(List<Dice> list)
        {
            foreach (Dice dice in list)
                occurenceList[dice.Value - 1]++;

        }
    }
}