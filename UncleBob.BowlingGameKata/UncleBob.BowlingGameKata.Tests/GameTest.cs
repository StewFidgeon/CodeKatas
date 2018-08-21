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
            RollMany(20, 0);

            Assert.AreEqual(0, g.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            RollMany(20, 1);

            Assert.AreEqual(20, g.Score());
        }

        //[TestMethod]
        //public void TestOneSpare()
        //{
        //    g.Roll(5);
        //    g.Roll(5);
        //    g.Roll(3);
        //    RollMany(17, 0);
        //    Assert.AreEqual(16, g.Score());
        //}

        private void RollMany(int n, int pins)
        {
            for (var i = 0; i < n; i++)
            {
                g.Roll(pins);
            }
        }
    }
}
