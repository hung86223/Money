namespace Money.Model
{
    public interface IExpression
    {
        IExpression Plus(MoneyBase addend);
        MoneyBase Reduce(string toCurrency);
    }
}