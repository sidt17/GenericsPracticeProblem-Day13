using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            FindMax findMax = new FindMax();
            Console.WriteLine("The max int value is :");
            Console.WriteLine(findMax.MaxValue<int>(75, 48, 50));
            Console.WriteLine("The max float value is :");
            Console.WriteLine(findMax.MaxValue<float>(40.36F, 80.762F, 30.865F));
            Console.WriteLine("The max string value is :");
            Console.WriteLine(findMax.MaxValue<string>("Apple", "Peach", "Banana"));

        }
    }
}


