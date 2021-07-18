namespace Money
{
    public abstract class MoneyBase
    {
        protected int Amount;
        protected string Currency;

        protected MoneyBase(int amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public bool Equal(MoneyBase money)
        {
            return Amount == money.Amount && GetType() == money.GetType();
        }

        public static MoneyBase Franc(int amount)
        {
            return new Franc(amount,"CHF");
        }

        public static MoneyBase Dollar(int amount)
        {
            return new Dollar(amount,"USD");
        }

        public abstract MoneyBase Times(int multiplier);
    }
}