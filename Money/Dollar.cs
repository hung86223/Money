namespace Money
{
    public class Dollar:MoneyBase
    {
        private string Currency;
        public Dollar(int amount, string currency)
        {
            Currency = currency;
            Amount = amount;
        }

        public override MoneyBase Times(int multiplier)
        {
            return MoneyBase.Dollar(Amount * multiplier);
        }

    }
}