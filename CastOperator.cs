using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class CastOperator : LinqRefactor<IEnumerable<string>>
    {
        object[] things = { "Sam", "Dave", "Greg", "Travis", "Dan", 2 };
        public override IEnumerable<string> WithLinq()
        => things.Select(t => t as string)
            .Where(t => t != null)
            .Cast<string>();

        public override IEnumerable<string> WithoutLinq()
        {
            List<string> allStrings = new List<string>();
            foreach (var v in things)
            {
                string z = v as string;
                if (z != null)
                    allStrings.Add(z);
            }
            return allStrings;
        }
    }
}
