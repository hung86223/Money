namespace Money.Model
{
    public class Sum:IExpression
    {
        public MoneyBase Augend;
        public MoneyBase Addend;

        public Sum(MoneyBase augend, MoneyBase addend)
        {
            Augend = augend;
            Addend = addend;
        }

        public IExpression Plus(MoneyBase addend)
        {
            throw new System.NotImplementedException();
        }
    }
}