using ExpectedObjects;
using Money;
using NUnit.Framework;

namespace MoneyTest
{
    [TestFixture]
    public class FrancTests
    {
        [Ignore("use test different class equality to cover")]
        [Test]
        public void TestMultiplication()
        {
            var franc = MoneyBase.Franc(5);
            FrancShouldEqual(MoneyBase.Franc(10),franc.Times(2));
            FrancShouldEqual(MoneyBase.Franc(15), franc.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            Assert.True(MoneyBase.Franc(5).Equal(MoneyBase.Franc(5)));
            Assert.False(MoneyBase.Franc(5).Equal(MoneyBase.Franc(6)));
            Assert.False(MoneyBase.Franc(5).Equal(MoneyBase.Dollar(5)));
        }

        [Test]
        public void TestDifferentClassEquality()
        {
            Assert.True(new MoneyBase(10,"CHF").Equal(new Franc(10,"CHF")));
        }

        private void FrancShouldEqual(MoneyBase expected, MoneyBase product)
        {
            expected.ToExpectedObject().ShouldEqual(product);
        }
    }
}