namespace Money
{
    public class Franc
    {
        private int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplie)
        {
            return new Franc(multiplie*amount);
        }

        public bool Equal(Franc franc)
        {
            return amount == franc.amount;
        }
    }
}