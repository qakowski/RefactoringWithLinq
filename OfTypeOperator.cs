using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class OfTypeOperator : LinqRefactor<IEnumerable<string>>
    {
        object[] things = { "Sam", 1, DateTime.Today, "Eric" };
        public override IEnumerable<string> WithLinq()
            => things.OfType<string>();

        public override IEnumerable<string> WithoutLinq()
        {
            var list = new List<string>();

            foreach (var v in things)
                if (v.GetType() == typeof(string))
                    list.Add(v as string);

            return list;
        }
    }
}
