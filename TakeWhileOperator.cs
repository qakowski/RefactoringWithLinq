using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class TakeWhileOperator : LinqRefactor<IEnumerable<int>>
    {
        int[] nums = { 14, 21, 24, 51, 131, 1, 11, 54 };
        public override IEnumerable<int> WithLinq()
        {
            List<int> until50l = nums.TakeWhile(n => n < 50).ToList();
            return until50l;
        }

        public override IEnumerable<int> WithoutLinq()
        {

            List<int> until50 = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 50)
                {
                    until50.Add(nums[i]);
                }
                else
                    break;
            }
            return until50;
        }
    }
}
