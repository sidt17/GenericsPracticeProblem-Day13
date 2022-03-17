using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Checkmax
    {
        public string Maxnumber(string a,string b,string c)
        { 
            


            if (a.CompareTo(b) ==1 && a.CompareTo(c) == 1)
            {
                return a;
            }
            if (b.CompareTo(a) == 1 && b.CompareTo(c) == 1)
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
