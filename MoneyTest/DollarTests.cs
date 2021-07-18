using ExpectedObjects;
using Money;
using NUnit.Framework;

namespace MoneyTest
{
    public class DollarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMultiplication()
        {
            var five = MoneyBase.Dollar(5);
            DollarShouldEqual(MoneyBase.Dollar(10), five.Times(2));
            DollarShouldEqual(MoneyBase.Dollar(15), five.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            Assert.True(MoneyBase.Dollar(5).Equal(MoneyBase.Dollar(5)));
            Assert.False(MoneyBase.Dollar(5).Equal(MoneyBase.Dollar(6)));
            Assert.False(MoneyBase.Dollar(5).Equal(MoneyBase.Franc(5)));
        }

        private void DollarShouldEqual(MoneyBase expected, MoneyBase product)
        {
            expected.ToExpectedObject().ShouldEqual(product);
        }
    }
}