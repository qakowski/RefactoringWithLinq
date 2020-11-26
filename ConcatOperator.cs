using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class ConcatOperator : LinqRefactor<IEnumerable<string>>
    {
        string[] names1 = { "Sam", "David", "Erik", "Daniel" };
        string[] names2 = { "David", "Erik", "Samuel" };

        public override IEnumerable<string> WithLinq()
            => names1.Concat(names2);

        public override IEnumerable<string> WithoutLinq()
        {
            string[] names = new string[names1.Length + names2.Length];
            for (int i = 0; i < names1.Length; i++)
                names[i] = names1[i];
            for (int i = 0, j = names1.Length; i < names2.Length; i++, j++)
                names[j] = names2[i];

            return names;
        }
    }
}
