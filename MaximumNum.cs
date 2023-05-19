using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPracticeProblem
{
    internal class MaximumNum<T> where T : IComparable
    {
        public T[] value;
        public MaximumNum(T[] value)
        {
            this.value = value;
        }
        public T FindMaximum()
        {
            T maximum = value[^1]; // Assume the first element is the maximum

            for (int i = 1; i < value.Length; i++)
            {
                if (value[i].CompareTo(maximum) > 0)
                {
                    maximum = value[i];
                }
            }

            return maximum;
        }
        public void PrintMaximumValue()
        {
            T maximum = FindMaximum();
            Console.WriteLine("Maximum value is " + maximum);
        }
        
    }

}
