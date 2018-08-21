using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UncleBob.BowlingGameKata.Tests
{
    [TestClass]
    public class GameTest
    {
        private static Game g;

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            g = new Game();
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            g = null;
        }

        [TestMethod]
        public void TestGutterGame()
        {
            for (var i = 0; i < 20; i++)
            {
                g.Roll(0);
            }

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            for (var i = 0; i < 20; i++)
            {
                g.Roll(1);
            }

            Assert.AreEqual(20, g.Score());
        }
    }
}
