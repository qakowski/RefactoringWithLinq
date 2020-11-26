using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class SequenceEqualer : LinqRefactor<IEnumerable<bool>>
    {
        int[] codes = { 343, 2132, 12, 32143, 234 };
        int[] expected = { 343, 12, 2132, 32143, 234 };

        public override IEnumerable<bool> WithLinq()
            => new List<bool>() { codes.SequenceEqual(expected) };

        public override IEnumerable<bool> WithoutLinq()
        {
            if (codes.Length == expected.Length)
            {
                for (int i = 0; i < codes.Length; i++)
                    if (codes[i] != expected[i])
                        return new List<bool>() { false };
                return new List<bool>() { true };
            }
            return new List<bool>() { false };
        }
    }
}
