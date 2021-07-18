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

        private void FrancShouldEqual(MoneyBase expected, MoneyBase product)
        {
            expected.ToExpectedObject().ShouldEqual(product);
        }
    }
}