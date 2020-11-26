using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RefactoringWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var type in Assembly.GetExecutingAssembly().GetTypes().Where(p => !p.IsAbstract && (p.IsSubclassOf(typeof(LinqRefactor<IEnumerable<string>>)) || p.IsSubclassOf(typeof(LinqRefactor<IEnumerable<int>>)) || p.IsSubclassOf(typeof(LinqRefactor<string>)) || p.IsSubclassOf(typeof(LinqRefactor<IEnumerable<bool>>)))))
            {
                var instance = Activator.CreateInstance(type);
                MethodInfo methodInfo = type.GetMethod("Run");
                var result = methodInfo.Invoke(instance, new object[] { type.Name});
            }
            Console.ReadKey();
        }
    }
}
