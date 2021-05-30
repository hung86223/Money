﻿using ExpectedObjects;
using Money;
using NUnit.Framework;

namespace MoneyTest
{
    [TestFixture]
    public class FrancTests
    {
        [Test]
        public void TestMultiplication()
        {
            var franc = new Franc(5);
            FrancShouldEqual(new Franc(10),franc.Times(2));
            FrancShouldEqual(new Franc(15),franc.Times(3));
        }
 [Test]
        public void TestEquality()
        {
            Assert.True(new Franc(5).Equal(new Franc(5)));
            Assert.False(new Franc(5).Equal(new Franc(6)));
        }
        private void FrancShouldEqual(Franc expected, Franc product)
        {
            expected.ToExpectedObject().ShouldEqual(product);
        }
    }
}