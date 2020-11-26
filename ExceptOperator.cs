using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class ExceptOperator : LinqRefactor<IEnumerable<string>>
    {
        string[] names1 = { "Sam", "David", "Eric", "Daniel" };
        string[] names2 = { "David", "Eric", "Samuel" };

        public override IEnumerable<string> WithLinq()
            => names1.Except(names2);

        public override IEnumerable<string> WithoutLinq()
        {
            List<string> exclusiveNames = new List<string>();
            for (int i = 0; i < names1.Length; i++)
            {
                if (Array.FindIndex(names2, m => m == names1[i]) == -1)
                    exclusiveNames.Add(names1[i]);
            }
            return exclusiveNames;
        }
    }
}
