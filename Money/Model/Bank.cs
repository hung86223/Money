namespace Money.Model
{
    public class Bank
    {
        public MoneyBase Reduce(IExpression money, string toCurrency)
        {
            if (money is MoneyBase)
            {
                return (MoneyBase)money;
            }
            var sum = (Sum)money;
            return sum.Reduce(toCurrency);
        }
    }
}