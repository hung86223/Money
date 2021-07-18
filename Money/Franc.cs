namespace Money
{
    public class Franc:MoneyBase
    {

        public Franc(double amount)
        {
            Amount = amount;
        }

        public override MoneyBase Times(int multiplier)
        {
            return new Franc(multiplier*Amount);
        }

    }
}