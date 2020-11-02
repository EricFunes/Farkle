using System;
using FarkleLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FarkleDice.Tests
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void givenValueDice_WhenCreatingNewDice_TheExpectedTrue()
        {
            var Dice = new Dice();
            Dice.Value = 6;

            var result = Dice.ToString();

            Assert.AreEqual("6", result);
        }
    }
}
