using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class OrderByAndOrderByDescendingOperator : LinqRefactor<IEnumerable<string>>
    {
        string[] codes = { "abc", "bc", "a", "d", "abcd" };
        public override IEnumerable<string> WithLinq()
            => codes.OrderBy(item => item.Length);

        public override IEnumerable<string> WithoutLinq()
        {
            StringLengthComparer slc = new StringLengthComparer();
            List<string> codesAsList = codes.ToList();
            codesAsList.Sort(slc);
            return codesAsList;
        }
    }

    public class StringLengthComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return x.Length.CompareTo(y.Length);
        }
    }
}
