using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            MaxCount<int> intValue = new MaxCount<int>(32, 12, 190, 105, 50);
            intValue.MaxValue();

            MaxCount<float> floatValue = new MaxCount<float>(74.23f, 18.63f, 65.93f, 88.99f, 70.86f);
            floatValue.MaxValue();

            MaxCount<string> stringValue = new MaxCount<string>("Grapes", "Mango", "Guava", "Orange", "Pinepale");
            stringValue.MaxValue();
        }
    }
}