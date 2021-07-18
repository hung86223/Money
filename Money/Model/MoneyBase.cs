namespace Money.Model
{
    public  class MoneyBase : IExpression
    {
        protected int Amount;
        protected string Currency;

        public MoneyBase(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public bool Equal(MoneyBase money)
        {
            return Amount == money.Amount && Currency.Equals(money.Currency);
        }

        public static MoneyBase Franc(int amount)
        {
            return new (amount,"CHF");
        }

        public static MoneyBase Dollar(int amount)
        {
            return new (amount,"USD");
        }

        public MoneyBase Times(int multiplier)
        {
            return new (Amount * multiplier,Currency);
        }

        public override string ToString()
        {
            return $"{nameof(Amount)}: {Amount}, {nameof(Currency)}: {Currency}";
        }

        public IExpression Plus(MoneyBase addend)
        {
            return new Sum(this, addend);
        }
    }
}