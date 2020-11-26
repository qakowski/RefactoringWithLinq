using System.Collections.Generic;
using System.Linq;

namespace RefactoringWithLinq
{
    class ZipOperator : LinqRefactor<IEnumerable<string>>
    {
        string[] salutations = {"Mr.", "Mrs.","Master.","Ms."};
        string[] names = { "Patrick", "Nancy", "Jon", "Jane" };

        public override IEnumerable<string> WithLinq()
            => salutations.Zip(names, (salutation, name) => salutation + " " + name + " Smith");

        public override IEnumerable<string> WithoutLinq()
        {
            List<string> allNames = new List<string>();
            for (int i = 0; i < salutations.Length; i++)
                allNames.Add(salutations[i] + " " + names[i] + " Smith");

            return allNames;
        }
    }
}
