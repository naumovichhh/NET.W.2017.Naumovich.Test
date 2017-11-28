using System.Linq;
using System.Collections.Generic;

namespace Task4.Solution
{
    public static class AveragingMethods
    {
        public static double Mean(List<double> values)
        {
            return values.Sum() / values.Count;
        }

        public static double Median(List<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}