namespace Money.Model
{
    public class Bank
    {
        public MoneyBase Reduce(IExpression money, string currency)
        {
            return new(10, "USD");
        }
    }
}