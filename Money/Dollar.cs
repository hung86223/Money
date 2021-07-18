namespace Money
{
    public class Dollar:MoneyBase
    {
        public Dollar(int amount, string currency) : base(amount,currency)
        {
        }

        public override MoneyBase Times(int multiplier)
        {
            return MoneyBase.Dollar(Amount * multiplier);
        }

    }
}