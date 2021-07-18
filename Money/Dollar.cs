namespace Money
{
    public class Dollar:MoneyBase
    {
        public Dollar(double amount)
        {
            Amount = amount;
        }

        public override Dollar Times(int multiplier)
        {
            return new(Amount * multiplier);
        }

    }
}