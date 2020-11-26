using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class DistnictOperator : LinqRefactor<IEnumerable<string>>
    {
        string[] names = { "Sam", "David", "Sam", "Eric", "Daniel", "Sam" };

        public override IEnumerable<string> WithLinq()
            => names.Distinct();

        public override IEnumerable<string> WithoutLinq()
        {
            Array.Sort(names);
            List<string> distinctNames = new List<string>();
            for (int i = 0; i < names.Length - 1; i++)
            {
                if (names[i] != names[i + 1])
                    distinctNames.Add(names[i]);
                else
                {
                    if (distinctNames[distinctNames.Count - 1] != names[i])
                        distinctNames.Add(names[i]);
                }
            }
            return distinctNames;
        }
    }
}
