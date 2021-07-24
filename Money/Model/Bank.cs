namespace Money.Model
{
    public class Bank
    {
        public MoneyBase Reduce(IExpression money, string toCurrency)
        {
            return money.Reduce(toCurrency);
        }
    }
}