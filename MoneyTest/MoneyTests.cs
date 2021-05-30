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
            five.times(2);
            Assert.AreEqual(10,five.Amount);
        }
    }

    public class Dollar
    {
        public Dollar(int amount)
        {
            throw new System.NotImplementedException();
        }

        public double Amount { get; set; }

        public void times(int multiplier)
        {
            throw new System.NotImplementedException();
        }
    }
}