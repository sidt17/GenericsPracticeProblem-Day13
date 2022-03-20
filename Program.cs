using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            MaxCount<int> intValue = new MaxCount<int>(57, 28, 45, 100, 96);
            intValue.PrintMax();

            MaxCount<float> floatValue = new MaxCount<float>(96.12f, 61.54f, 10.99f, 38.4f, 75.98f);
            floatValue.PrintMax();

            MaxCount<string> stringValue = new MaxCount<string>("Grapes", "Papaya", "Orange", "Apple", "Banana");
            stringValue.PrintMax();
        }
    }
}