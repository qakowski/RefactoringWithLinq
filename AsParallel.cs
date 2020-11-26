using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class AsParallel : LinqRefactor<List<int>>
    {
        public override List<int> WithLinq()
        {
            List<int> Qsp = new List<int>();
            for (int i = 0; i < 2; i++)
                Qsp = Enumerable.Range(1, 10000).AsParallel().Where(d => Enumerable.Range(2, d / 2).All(e => d % e != 0)).ToList();

            return Qsp;
        }

        public override List<int> WithoutLinq()
        {
            List<int> Qs = new List<int>();
            for (int i = 0; i < 2; i++)
                Qs = Enumerable.Range(1, 10000).Where(d => Enumerable.Range(2, d / 2)
                               .All(e => d % e != 0))
                               .ToList();
            return Qs;
        }
    }
}
