using FarkleLib;
using System.Collections.Generic;

namespace Farkle
{
    public class Game : IGame
    {
        private const int diceNb = 6;
        public List<Dice> StartingList, BoardList, EndList;
        private List<int> occurenceList;
        private List<Player> playerList;
        private int playerNb;

        public Game()
        {
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
            BoardList = playerList[playerNb].ThrowDice(StartingList, BoardList);

            return BoardList;
        }

        public bool Verification(List<Dice> list)
        {
            fillOccurenceList(list);

            if (check123456())
                return true;
            else if (checkThreePairs())
                return true;

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

            return false;
        }

        private bool check123456()
        {
            foreach (int diceNb in occurenceList)
                if (diceNb != 1)
                    return false;
            playerList[playerNb].Score += 3000;

            return true;
        }

        private bool checkThreePairs()
        {
            foreach (int diceNb in occurenceList)
                if (occurenceList.Count != 6 || diceNb % 2 != 0)
                    return false;
            playerList[playerNb].Score += 1500;
            return true;
        }

        private bool checkTrio()
        {
            for (int i = 0; i < occurenceList.Count; i++)
                if (occurenceList[i] == 3)
                {
                    occurenceList[i] -= 3;
                    playerList[playerNb].Score += (i + 1) * 100;
                    return true;
                }
            return false;
        }

        private bool check1Or5()
        {
            if (occurenceList[0] > 0)
            {
                occurenceList[0]--;
                playerList[playerNb].Score += 100;
                return true;
            }
            else if (occurenceList[4] > 0)
            {
                occurenceList[4]--;
                playerList[playerNb].Score += 50;
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