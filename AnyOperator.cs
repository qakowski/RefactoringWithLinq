using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class AnyOperator : LinqRefactor<IEnumerable<bool>>
    {
        private readonly int[] nums = { 14, 21, 24, 51, 131, 1, 11, 54 };

        public override IEnumerable<bool> WithLinq()
        {
            bool isAny = nums.Any(n => n >= 150);
            return new List<bool>() { isAny };
        }

        public override IEnumerable<bool> WithoutLinq()
        {
            bool isAny = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 150)
                {
                    isAny = true;
                    break;
                }
            }
            return new List<bool>() { isAny };
        }
    }
}
