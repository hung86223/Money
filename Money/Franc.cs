namespace Money
{
    public class Franc:MoneyBase
    {

        public Franc(double amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplie)
        {
            return new (multiplie*amount);
        }

    }
}