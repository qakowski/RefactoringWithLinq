using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class SkipOperator : LinqRefactor<IEnumerable<int>>
    {
        int[] nums = { 14, 21, 24, 51, 131, 1, 11, 54 };
        public override IEnumerable<int> WithLinq()
        {
            int[] skip4l = nums.Skip(4).ToArray();
            return skip4l;
        }

        public override IEnumerable<int> WithoutLinq()
        {
            int[] skip4 = new int[nums.Length - 4];
            for (int i = 4, j = 0; i < nums.Length; i++, j++)
            {
                skip4[j] = nums[i];
            }
            return skip4;
        }
    }
}
