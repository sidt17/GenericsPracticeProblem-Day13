using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Checkmax
    {
        public int Maxnumber(int a, int b, int c)
        {
            
            if (a.CompareTo(b) == 1 && a.CompareTo(c) == 1)      //comparing values to each other by using compareTo keyword
            {
                return a;
            }
            if (b.CompareTo(a) ==1 && b.CompareTo(c) == 1)
            {
                return b;
            }
            if (c.CompareTo(a) == 1 && c.CompareTo(b) == 1)
            {
                return c;
            }

            return default;

        }


    }
          

    


         
    
    
}
