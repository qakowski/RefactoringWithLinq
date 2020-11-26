using System.Linq;

namespace RefactoringWithLinq
{
    class AggregateOperator : LinqRefactor<string>
    {
        string[] names = { "Greg", "Travis", "Dan" };
        public override string WithLinq()
            => names.Aggregate((f, s) => f + ", " + s);

        public override string WithoutLinq()
        {
            var result = string.Empty ;
            for (int k = 0; k < names.Length; k++)
            {
                if (k + 1 == names.Length)
                    result += $"{names[k]}";
                else
                    result += $"{names[k]}, ";
            }
            return result;
        }
    }
}
