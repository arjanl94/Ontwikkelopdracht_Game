using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE2Game;

namespace GameTest
{
    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void TestPlayer()
        {            
            Player player = new Player("Piet", 100);
            Assert.AreEqual("Piet", player.Name, "Naam is incorrect");
            Assert.AreEqual(100, player.Hitpoints, "Hitpoints is incorrect");
        }
    }
}
