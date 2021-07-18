namespace Money
{
    public class Franc:MoneyBase
    {
        private string Currency;

        public Franc(int amount, string currency)
        {
            Currency = currency;
            Amount = amount;
        }

        public override MoneyBase Times(int multiplier)
        {
            return Franc(multiplier*Amount);
        }

    }
}