using System;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            Checkmax value = new Checkmax();
            int d = value.Maxnumber(2, 5, 8);
            Console.WriteLine(d + "is the largest number");

        }
    }
}
