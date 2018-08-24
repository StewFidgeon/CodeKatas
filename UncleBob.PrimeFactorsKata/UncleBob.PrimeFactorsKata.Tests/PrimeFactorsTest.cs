using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UncleBob.PrimeFactorsKata.Tests
{
    [TestClass]
    public class PrimeFactorsTest
    {
        private PrimeFactors _primeFactors;

        [TestInitialize]
        public void Initialize()
        {
            _primeFactors = new PrimeFactors();
        }

        [TestCleanup]
        public void CleanUp()
        {
            _primeFactors = null;
        }

        [TestMethod]
        public void TestOne()
        {
            CollectionAssert.AreEqual(MakeList(), _primeFactors.Generate(1));
        }

        [TestMethod]
        public void TestTwo()
        {
            CollectionAssert.AreEqual(MakeList(2), _primeFactors.Generate(2));
        }

        [TestMethod]
        public void TestThree()
        {
            CollectionAssert.AreEqual(MakeList(3), _primeFactors.Generate(3));
        }

        [TestMethod]
        public void TestFour()
        {
            CollectionAssert.AreEqual(MakeList(2,2), _primeFactors.Generate(4));
        }

        [TestMethod]
        public void TestSix()
        {
            CollectionAssert.AreEqual(MakeList(2, 3), _primeFactors.Generate(6));
        }

        [TestMethod]
        public void TestEight()
        {
            CollectionAssert.AreEqual(MakeList(2, 2, 2), _primeFactors.Generate(8));
        }

        private List<int> MakeList(params int[] values)
        {
            var list = new List<int>();
            foreach (var value in values)
            {
                list.Add(value);
            }

            return list;
        }
    }
}
