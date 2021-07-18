namespace Money.Model
{
    public interface IExpression
    {
        IExpression Plus(MoneyBase addend);
    }
}