using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MaxCount<T>
    {

        public T[] Values;

        public MaxCount(params T[] Values)
        {
            this.Values = Values;
        }

        public T[] SortValues(T[] Values)
        {
            Array.Sort(Values);
            return Values;
        }

        public T TestMaximum(T[] values)
        {
            var maxValue = SortValues(Values);
            return maxValue[maxValue.Length - 1];
        }
        public void PrintMax()
        {
            Console.WriteLine("max int value is :" + TestMaximum(Values));
            Console.WriteLine("max float value is :" + TestMaximum(Values));
            Console.WriteLine("max string value is :" + TestMaximum(Values));
        }

    }
}