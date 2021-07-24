namespace Money.Model
{
    public class Bank
    {
        public MoneyBase Reduce(IExpression money, string toCurrency)
        {
            var sum = (Sum)money;
            var amount = sum.Addend.Amount+sum.Augend.Amount;
            return new MoneyBase(amount, toCurrency);
        }
    }
}