using System;
using System.Collections.Generic;
using FarkleLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarklePlayer.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void givenNameAndScore_WhenCreatingNewPlayer_ThenExpectedTrue()
        {
            // Arrange
            var player = new Player();
            string name = "Eric";
            int score = 0;

            player.Name = name;
            player.Score = score;

            Assert.AreEqual("Eric 0", player.ToString());
        }

        [TestMethod]
        public void givenNewPlayer_AndThrowsStartingDiceToBoardingList_ThenExpectedTrue()
        {
            // Assert
            var player = new Player();
            List<Dice> startingList = new List<Dice>();
            List<Dice> boardList = new List<Dice>();

            // Act
            for (int i = 0; i < 6; i++)
            {
                Dice dice = new Dice();
                startingList.Add(dice);
            }

            var result = player.ThrowDice(startingList, boardList);

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
