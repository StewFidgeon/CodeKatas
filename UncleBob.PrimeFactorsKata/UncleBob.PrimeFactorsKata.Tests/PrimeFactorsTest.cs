using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UncleBob.PrimeFactorsKata.Tests
{
    [TestClass]
    public class PrimeFactorsTest
    {
        private List<int> _list = new List<int>();

        [TestMethod]
        public void TestOne()
        {
            CollectionAssert.AreEqual(_list, PrimeFactors.Generate(1));
        }
    }
}
