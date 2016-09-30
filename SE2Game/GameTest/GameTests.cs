using System.Drawing;
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
            Player player = new Player("Piet", 100, new Point());
            Assert.AreEqual("Piet", player.Name, "Naam is incorrect");
            Assert.AreEqual(100, player.Hitpoints, "Hitpoints is incorrect");
            Assert.AreEqual(new Point(), player.Location, "Locatie is incorrect");
        }
        [TestMethod]
        public void TestEnemy()
        {
            
            Enemy enemy = new Enemy(100, 20, new Point());
            Assert.AreEqual(100, enemy.Hitpoints, "Hitpoints is incorrect");
            Assert.AreEqual(20, enemy.Damage, "Damage is incorrect");
            Assert.AreEqual(new Point(), enemy.Location, "Locatie is incorrect");
        }
    }
}
