namespace Money.Model
{
    public class Bank
    {
        public MoneyBase Reduce(IExpression money, string toCurrency)
        {
            var sum = (Sum)money;
            return sum.Reduce(toCurrency);
        }
    }
}