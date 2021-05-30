namespace Money
{
    public class Dollar:MoneyBase
    {
        public Dollar(double amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new(amount * multiplier);
        }

    }
}