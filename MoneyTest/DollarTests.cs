using ExpectedObjects;
using Money.Model;
using NUnit.Framework;

namespace MoneyTest
{
    public class DollarTests
    {
        private Bank _bank;

        [SetUp]
        public void Setup()
        {
            _bank = new Bank();
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

        [Test]
        public void TestPlusReturnSum()
        {
            var five = MoneyBase.Dollar(5);
            var result = five.Plus(five);
            var sum = (Sum)result;

            MoneyShouldEqual(five, sum.Augend);
            MoneyShouldEqual(five, sum.Addend);
        }

        [Test]
        public void TestReduceSum()
        {
            var sum = new Sum(MoneyBase.Dollar(3),MoneyBase.Dollar(4) );

            var actual = _bank.Reduce(sum,"USD");

            MoneyShouldEqual(MoneyBase.Dollar(7),  actual);
        }

        [Test]
        public void TestReduceMoney()
        {
            var actual = _bank.Reduce(MoneyBase.Dollar(1), "USD");

            MoneyShouldEqual(MoneyBase.Dollar(1),actual);
        }

        private void MoneyShouldEqual(MoneyBase expected, MoneyBase actual)
        {
            expected.ToExpectedObject().ShouldEqual(actual);
        }
    }
}