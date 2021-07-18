namespace Money
{
    public abstract class MoneyBase
    {
        protected double Amount;

        public bool Equal(MoneyBase money)
        {
            return Amount == money.Amount;
        }

        public static MoneyBase Franc(int amount)
        {
            return new Franc(amount);
        }

        public static MoneyBase Dollar(int amount)
        {
            return new Dollar(amount);
        }

        public abstract MoneyBase Times(int multiplier);
    }
}