﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UncleBob.PrimeFactorsKata.Tests
{
    [TestClass]
    public class PrimeFactorsTest
    {
        [TestMethod]
        public void TestOne()
        {
            CollectionAssert.AreEqual(MakeList(), PrimeFactors.Generate(1));
        }

        [TestMethod]
        public void TestTwo()
        {
            CollectionAssert.AreEqual(MakeList(2), PrimeFactors.Generate(2));
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
