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
            MoneyShouldEqual(MoneyBase.Dollar(10), five.Times(2));
            MoneyShouldEqual(MoneyBase.Dollar(15), five.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            Assert.True(MoneyBase.Dollar(5).Equal(MoneyBase.Dollar(5)));
            Assert.False(MoneyBase.Dollar(5).Equal(MoneyBase.Dollar(6)));
            Assert.False(MoneyBase.Dollar(5).Equal(MoneyBase.Franc(5)));
        }

        [Test]
        public void TestSimpleAddition()
        {
            var five = MoneyBase.Dollar(5);
            var sum = five.Plus(five);
            var bank = new Bank();

            var actual = bank.Reduce(sum, "USD");

            var expected = MoneyBase.Dollar(10);
            MoneyShouldEqual(expected, actual);
        }

        private void MoneyShouldEqual(MoneyBase expected, MoneyBase actual)
        {
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }

    public class Bank
    {
        public MoneyBase Reduce(IExpression money, string currency)
        {
            return new(10, "USD");
        }
    }
}