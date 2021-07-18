using ExpectedObjects;
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
            var franc = MoneyBase.Franc(5);
            FrancShouldEqual(MoneyBase.Franc(10), franc.Times(2));
            FrancShouldEqual(MoneyBase.Franc(15), franc.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            Assert.True(new Franc(5).Equal(new Franc(5)));
            Assert.False(new Franc(5).Equal(new Franc(6)));
            Assert.False(new Franc(5).Equal(new Dollar(5)));
        }

        private void FrancShouldEqual(MoneyBase expected, MoneyBase product)
        {
            expected.ToExpectedObject().ShouldEqual(product);
        }
    }
}