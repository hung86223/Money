namespace Money
{
    public class Dollar
    {
        private double amount;

        public Dollar(double amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {
            return new(amount * multiplier);
        }

        public bool Equal(Dollar dollar)
        {
            return amount == dollar.amount;
        }
    }
}