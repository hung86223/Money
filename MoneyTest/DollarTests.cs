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
            var five = new Dollar(5);
            DollarShouldEqual(new Dollar(10), five.Times(2));
            DollarShouldEqual(new Dollar(15), five.Times(3));
        }

        private void DollarShouldEqual(Dollar expected, Dollar product)
        {
            expected.ToExpectedObject().ShouldEqual(product);
        }

        [Test]
        public void TestEquality()
        {
            Assert.True(new Dollar(5).Equal(new Dollar(5)));
            Assert.False(new Dollar(5).Equal(new Dollar(6)));
        }
    }
}