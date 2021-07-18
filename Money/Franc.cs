namespace Money
{
    public class Franc:MoneyBase
    {
        public Franc(int amount, string currency) : base(amount,currency)
        {
        }

        public override MoneyBase Times(int multiplier)
        {
            return Franc(multiplier*Amount);
        }

    }
}