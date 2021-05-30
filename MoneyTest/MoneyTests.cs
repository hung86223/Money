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
            five.Times(2);
            Assert.AreEqual(10,five.Amount);
        }
    }

    public class Dollar
    {
        public Dollar(int amount)
        {
            Amount = amount;
        }

        public double Amount { get; set; }

        public void Times(int multiplier)
        {
            Amount *= multiplier;
        }
    }
}