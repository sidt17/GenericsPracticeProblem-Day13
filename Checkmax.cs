using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Checkmax
    {
        public void Maxnumber()
        {
            string a = "Apple";
            string b = "Peach";
            string c = "Banana";


            if (a.CompareTo(b) ==1 && a.CompareTo(c) == 1)
            {
                Console.WriteLine("The max is " + a);
            }
            if (b.CompareTo(a) == 1 && b.CompareTo(c) == 1)
            {
                Console.WriteLine("The max is " + b);
            }
            if (c.CompareTo(a) == 1 && c.CompareTo(b) == 1)
            {
                Console.WriteLine("The max is " + c);
            }
           
           

        }


    }









}
