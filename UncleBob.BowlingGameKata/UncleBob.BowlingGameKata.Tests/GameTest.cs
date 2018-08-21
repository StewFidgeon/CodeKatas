using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UncleBob.BowlingGameKata.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void TestGutterGame()
        {
            var g = new Game();

            for (var i = 0; i < 20; i++)
            {
                g.Roll(0);
            }

            Assert.AreEqual(0, g.Score());
        }
    }
}
