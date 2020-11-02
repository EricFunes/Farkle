using System;
using System.Collections.Generic;
using Farkle;
using FarkleLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarklesGame.Tests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void givenNewGame_whenPlayerListAdded_thenListNotNull()
        {
            //Arrange
            var game = new Game();
            string name = "Bob";
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();

            //Act
            player.Name = name;
            list.Add(player);
            game.PlayerList = list;

            //Assert
            Assert.IsNotNull(game.PlayerList);

        }

        [TestMethod]
        public void givenNewGame_whenPlayerListAdded_thenScoreExpectedTrue()
        {
            //Arrange
            var game = new Game();
            Player player1 = new Player();
            Player player2 = new Player();
            List<IPlayer> list = new List<IPlayer>();

            //Act
            list.Add(player1);
            list.Add(player2);
            game.PlayerList = list;
            game.NextPlayer();
            game.NextPlayer();

            //Assert
            Assert.AreEqual(0, game.getPlayerScore());
        }
        [TestMethod]
        public void givenNewGame_whenPlayerListAdded_thenNameExpectedTrue()
        {
            //Arrange
            var game = new Game();
            string name = "Bob";
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();

            //Act
            player.Name = name;
            list.Add(player);
            game.PlayerList = list;

            //Assert
            Assert.AreEqual("Bob", game.getPlayerName());
        }

        [TestMethod]
        public void givenNewGame_whenScoreIsHigh_thenNameExpectedTrue()
        {
            //Arrange
            var game = new Game();
            int score = 10001;
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();

            //Act
            player.Score = score;
            list.Add(player);
            game.PlayerList = list;


            //Assert
            Assert.IsTrue(game.Win());
        }

        [TestMethod]
        public void givenNewGame_whenScoreIsHigh_thenNameExpectedFalse()
        {
            //Arrange
            var game = new Game();
            int score = 9999;
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();

            //Act
            player.Score = score;
            list.Add(player);
            game.PlayerList = list;


            //Assert
            Assert.IsFalse(game.Win());
        }

        [TestMethod]
        public void givenNewGame_whenThrowDices_thenBoardListNotNull()
        {
            //Arrange
            var game = new Game();
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();

            //Act
            list.Add(player);
            game.PlayerList = list;
            game.ThrowDices();


            //Assert
            Assert.IsNotNull(game.BoardList);
        }

        [TestMethod]
        public void givenNewGame_whenThrowDices_thenVerificationIsFalse()
        {
            //Arrange
            var game = new Game();
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();
            List<Dice> diceList = new List<Dice>();
            Dice d = new Dice();

            //Act
            list.Add(player);
            game.PlayerList = list;
            d.Value = 2;
            diceList.Add(d);

            //Assert
            Assert.IsFalse(game.Verification(diceList, false));
        }

        [TestMethod]
        public void givenNewGame_whenThrowDices_thenVerification1Or5IsTrue()
        {
            //Arrange
            var game = new Game();
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();
            List<Dice> diceList = new List<Dice>();
            Dice d1 = new Dice();
            Dice d2 = new Dice();

            //Act
            list.Add(player);
            game.PlayerList = list;
            d1.Value = 1;
            d2.Value = 5;
            diceList.Add(d1);
            diceList.Add(d2);

            //Assert
            Assert.IsTrue(game.Verification(diceList, false));
        }

        [TestMethod]
        public void givenNewGame_whenThrowDices_thenVerificationTrioIsTrue()
        {
            //Arrange
            var game = new Game();
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();
            List<Dice> diceList = new List<Dice>();
            Dice d1 = new Dice();
            Dice d2 = new Dice();
            Dice d3 = new Dice();

            //Act
            list.Add(player);
            game.PlayerList = list;
            d1.Value = 1;
            d2.Value = 1;
            d3.Value = 1;
            diceList.Add(d1);
            diceList.Add(d2);
            diceList.Add(d3);

            //Assert
            Assert.IsTrue(game.Verification(diceList, false));
        }

        [TestMethod]
        public void givenNewGame_whenThrowDices_thenVerificationPairsIsTrue()
        {
            //Arrange
            var game = new Game();
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();
            List<Dice> diceList = new List<Dice>();
            Dice d1 = new Dice();
            Dice d2 = new Dice();
            Dice d3 = new Dice();
            Dice d4 = new Dice();
            Dice d5 = new Dice();
            Dice d6 = new Dice();

            //Act
            list.Add(player);
            game.PlayerList = list;
            d1.Value = 1;
            d2.Value = 1;
            d3.Value = 1;
            d4.Value = 1;
            d5.Value = 1;
            d6.Value = 1;
            diceList.Add(d1);
            diceList.Add(d2);
            diceList.Add(d3);
            diceList.Add(d4);
            diceList.Add(d5);
            diceList.Add(d6);

            //Assert
            Assert.IsTrue(game.Verification(diceList, false));
        }

        [TestMethod]
        public void givenNewGame_whenThrowDices_thenVerification6IsTrue()
        {
            //Arrange
            var game = new Game();
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();
            List<Dice> diceList = new List<Dice>();
            Dice d1 = new Dice();
            Dice d2 = new Dice();
            Dice d3 = new Dice();
            Dice d4 = new Dice();
            Dice d5 = new Dice();
            Dice d6 = new Dice();

            //Act
            list.Add(player);
            game.PlayerList = list;
            d1.Value = 1;
            d2.Value = 2;
            d3.Value = 3;
            d4.Value = 4;
            d5.Value = 5;
            d6.Value = 6;
            diceList.Add(d1);
            diceList.Add(d2);
            diceList.Add(d3);
            diceList.Add(d4);
            diceList.Add(d5);
            diceList.Add(d6);

            //Assert
            Assert.IsTrue(game.Verification(diceList, false));
        }

        [TestMethod]
        public void givenNewGame_whenThrowDices_thenVerificationTestIsTrue()
        {
            //Arrange
            var game = new Game();
            Player player = new Player();
            List<IPlayer> list = new List<IPlayer>();
            List<Dice> diceList = new List<Dice>();
            Dice d1 = new Dice();

            //Act
            list.Add(player);
            game.PlayerList = list;
            d1.Value = 1;
            diceList.Add(d1);

            //Assert
            Assert.IsTrue(game.VerificationTest(diceList));
        }
    }
}
