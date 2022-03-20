using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class MaxCount<T>
    {
        public T[] ValuesInArray;

        public MaxCount(params T[] ValuesInArray)
        {
            this.ValuesInArray = ValuesInArray;
        }

        public void MaxValue()
        {
            Array.Sort(this.ValuesInArray);

            Console.WriteLine("max value:" + this.ValuesInArray[ValuesInArray.Length - 1]);
        }
    }
}



