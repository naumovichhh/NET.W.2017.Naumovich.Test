using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4.Solution
{
    public delegate double AveragingMethod(List<double> list);

    public class Calculator
    {
        public double CalculateAverage(List<double> values, AveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }

            return averagingMethod(values);
        }
    }
}
