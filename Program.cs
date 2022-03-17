using System;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            Checkmax value = new Checkmax();
            float d = value.Maxnumber(6.785f, 4.563f, 2.576f);
            Console.WriteLine(d + " is the largest number at first position");
        }
    }
}
