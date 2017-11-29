using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6.Solution
{
    public class SequenceGenerator<T>
    {
        private T x1;
        private T x2;
        private Func<T, T, T> function;

        public SequenceGenerator(T x1, T x2, Func<T, T, T> function)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.function = function;
        }

        public T[] Generate(int n)
        {
            if (n < 3)
                throw new ArgumentException("N must be more than 2", nameof(n));

            T[] sequence = new T[n];
            GenerateRecursion(n, sequence);
            return sequence;
        }

        private void GenerateRecursion(int n, T[] sequence)
        {
            if (n == 2)
            {
                sequence[0] = x1;
                sequence[1] = x2;
                return;
            }

            GenerateRecursion(n - 1, sequence);
            sequence[n - 1] = function(sequence[n - 2], sequence[n - 3]);
        }
    }
}
