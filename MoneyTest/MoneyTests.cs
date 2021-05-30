using NUnit.Framework;

namespace MoneyTest
{
    public class MoneysTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestMultiplication()
        {
            var five = new Dollar(5);
            var product = five.Times(2);
            Assert.AreEqual(10,product.amount);
            product = five.Times(3);
            Assert.AreEqual(15,product.amount);
        }
    }

    public class Dollar
    {
        public double amount;

        public Dollar(double amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new(amount*multiplier);
        }
    }
}