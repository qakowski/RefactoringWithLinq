using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RefactoringWithLinq
{
    class WhereOperator : LinqRefactor<IEnumerable<int>>
    {
        int[] nums = { 14, 21, 24, 51, 131, 1, 11, 54 };
        public override IEnumerable<int> WithLinq()
        {
            int[] above50l = nums.Where(n => n > 50).ToArray();
            return above50l;
        }

        public override IEnumerable<int> WithoutLinq()
        {
            int[] above50 = new int[nums.Length];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 50)
                {
                    above50[j] = nums[i];
                    j++;
                }
            }
            Array.Resize(ref above50, j);
            return above50;
        }
    }
}
