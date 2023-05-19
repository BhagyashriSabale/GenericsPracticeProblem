using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    internal class MaximumNum<T> where T : IComparable
    {
        private List<T> values;
        public MaximumNum(params T[] values)
        {
            this.values = new List<T>(values);
        }
        public T TestMaximum()
        {
            SortValues();
            T maximum = values[^1];
            
            return maximum;
        }
        private void SortValues()
        {
            values.Sort();
        }
       
        private static T Maximum(T value1, T value2, T value3)
        {
            T maximum = value1; // Assume the first value is the maximum

            if (value2.CompareTo(maximum) > 0)
            {
                maximum = value2;
            }

            if (value3.CompareTo(maximum) > 0)
            {
                maximum = value3;
            }

            return maximum;
        }
        
    }

}
