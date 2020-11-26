using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    /// <summary>
    /// To zadanie zawiera blad w pliku znajdujacym sie w LinqPad
    /// Rezultaty tych dwoch zapytan sie roznia(linq zwroci true gdy stare podejscie zwroci false)
    /// Problemem jest sprawdzanie wartosci - linq sprawdza czy wszystkie sa mniejsze od 150 gdy stare podejscie sprawdza czy jakikolwiek element jest mniejszy od 150
    /// </summary>
    class AllOperator : LinqRefactor<IEnumerable<bool>>
    {
        int[] nums = { 14, 21, 24, 51, 131, 1, 11, 54 };

        public override IEnumerable<bool> WithLinq()
        {
            bool isAll2 = nums.All(n => n < 150);
            return new List<bool>() { isAll2 };
        }

        public override IEnumerable<bool> WithoutLinq()
        {
            bool isAll = true;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 150)
                {
                    isAll = false;
                    break;
                }
            }
            return new List<bool>() { isAll };
        }
    }
}
