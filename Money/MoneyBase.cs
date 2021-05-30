namespace Money
{
    public class MoneyBase
    {
        protected double amount;
        
        public bool Equal(MoneyBase money)
        {
            return amount == money.amount;
        }
    }
}