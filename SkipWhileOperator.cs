using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class SkipWhileOperator : LinqRefactor<IEnumerable<int>>
    {
        int[] nums = { 14, 21, 24, 51, 131, 1, 11, 54 };
        public override IEnumerable<int> WithLinq()
        {
            List<int> skipWhileDivisibleBy7l = nums.SkipWhile(n => n % 7 == 0).ToList();
            return skipWhileDivisibleBy7l;
        }

        public override IEnumerable<int> WithoutLinq()
        {
            
            List<int> skipWhileDivisibleBy7 = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 7 == 0)
                {
                    continue;
                }
                else
                    skipWhileDivisibleBy7.Add(nums[i]);
            }
            return skipWhileDivisibleBy7;
        }
    }
}
