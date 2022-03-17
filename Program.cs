using System;
namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            Checkmax value = new Checkmax();
            float d = value.Maxnumber(3.85f, 4.563f, 8.6454f);
            Console.WriteLine(d + " is the largest number at third position");
        }
    }
}
