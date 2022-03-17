using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Checkmax
    {
        public void  Maxnumber()
        {
            int a = 50;
            int b = 30;
            int c = 10;
            if (a.CompareTo(b) == 1 && a.CompareTo(c) == 1)      //comparing values to each other by using compareTo keyword
            {
                Console.WriteLine("a is largest number that is " + a);
            }
            if (b.CompareTo(a) ==1 && b.CompareTo(c) == 1)
            {
                Console.WriteLine("b is largest number that is " + b);
            }
            if (c.CompareTo(a) == 1 && c.CompareTo(b) == 1)
            {
                Console.WriteLine("c is largest number that is " + c);
            }
           


        }


    }
          

    


         
    
    
}
