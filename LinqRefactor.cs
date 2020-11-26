using System;
using System.Collections;
using System.Diagnostics;

namespace RefactoringWithLinq
{
    abstract class LinqRefactor<TResult> where TResult : IEnumerable
    {
        public virtual void Run(string operatorUsed)
        {
            var linqStopwatch = new Stopwatch();
            var withoutLinqStopwatch = new Stopwatch();
            Console.WriteLine($"\nOperator: {operatorUsed}");

            linqStopwatch.Start();
            var linqResult = WithLinq();
            linqStopwatch.Stop();
            Console.WriteLine($"Linq - elapsed miliseconds: {linqStopwatch.ElapsedMilliseconds}");
            Console.Write("Linq result: ");
            
            if (linqResult.GetType() != typeof(string))
            {
                foreach (var result in linqResult)
                {
                    Console.Write($"{result} ");
                }
            }
            else
                Console.Write($"{linqResult}");

            withoutLinqStopwatch.Start();
            var withoutLinqResult = WithoutLinq();
            withoutLinqStopwatch.Stop();
            Console.WriteLine($"\n\nWithout linq - elapsed miliseconds: {withoutLinqStopwatch.ElapsedMilliseconds}");
            Console.Write("Without Linq result: ");

            if (withoutLinqResult.GetType() != typeof(string))
            {
                foreach (var result in withoutLinqResult)
                {
                    Console.Write($"{result} ");
                }
            }
            else
                Console.Write($"{withoutLinqResult}");

            Console.WriteLine("\n-------------------------------");
        }

        public abstract TResult WithLinq();
        public abstract TResult WithoutLinq();
    }
}
