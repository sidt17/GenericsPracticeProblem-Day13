using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Checkmax findMax = new Checkmax();
            Console.WriteLine("The max int value is :");
            Console.WriteLine(findMax.MaxValue<int>(15, 28, 10));
            Console.WriteLine("The max float value is :");
            Console.WriteLine(findMax.MaxValue<float>(20.36f, 10.762f, 13.865f));
            Console.WriteLine("The max string value is :");
            Console.WriteLine(findMax.MaxValue<string>("Apple", "Peach", "Banana"));

        }
    }
}


