using System;
using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class UnionOperator : LinqRefactor<IEnumerable<string>>
    {
        string[] names1 = { "Sam", "David", "Sam", "Eric", "Daniel", "Sam" };
        string[] names2 = { "David", "Eric", "Samuel" };

		public override IEnumerable<string> WithLinq()
			=> names1.Union(names2);
		
        public override IEnumerable<string> WithoutLinq()
        {
			string[] names = new string[names1.Length + names2.Length];
			for (int i = 0; i < names1.Length; i++)
				names[i] = names1[i];
			for (int i = 0, j = names1.Length; i < names2.Length; i++, j++)
				names[j] = names2[i];
			List<string> unionNames = new List<string>();
			Array.Sort(names);
			for (int i = 0; i < names.Length - 1; i++)
			{
				if (names[i] != names[i + 1])
				{
					if (unionNames.Count > 0)
					{
						if (unionNames[unionNames.Count - 1] != names[i])
							unionNames.Add(names[i]);
					}
					else
						unionNames.Add(names[i]);
				}
				else
				{
					if (unionNames[unionNames.Count - 1] != names[i])
						unionNames.Add(names[i]);
				}
			}
			if (names[names.Length - 1] != names[names.Length - 2])
				unionNames.Add(names[names.Length - 1]);
			return unionNames;
		}
    }
}
