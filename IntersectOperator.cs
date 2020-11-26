using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class IntersectOperator : LinqRefactor<IEnumerable<string>>
    {
        string[] names1 = { "Sam", "David", "Sam", "Eric", "Daniel", "Sam" };
        string[] names2 = { "David", "Eric", "Samuel" };

        public override IEnumerable<string> WithLinq()
            => names1.Intersect(names2);

        public override IEnumerable<string> WithoutLinq()
        {
            List<string> commonNames = new List<string>();
            for (int i = 0; i < names1.Length; i++)
            {
                if (Array.FindIndex(names2, m => m == names1[i]) != -1)
                    commonNames.Add(names1[i]);
            }
            return commonNames;
        }
    }
}
