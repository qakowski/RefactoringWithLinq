using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class TakeOperator : LinqRefactor<IEnumerable<int>>
    {
        int[] nums = { 14, 21, 24, 51, 131, 1, 11, 54 };
        public override IEnumerable<int> WithLinq()
        {
            int[] first4l = nums.Take(4).ToArray();
            return first4l;
        }

        public override IEnumerable<int> WithoutLinq()
        {
            
            int[] first4 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                first4[i] = nums[i];
            }
            return first4;
        }
    }
}
