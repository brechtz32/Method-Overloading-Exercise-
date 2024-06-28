using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal y, decimal z)
        {
            return y + z;
        }

        public static string Add(int c, int d, bool isTrue)
        {
            if (isTrue && (c + d) != 1)
            {
                return $"{c + d} dollars";
            }
            else if (isTrue && (c + d) == 1)
            {
                return $"{c + d} dollar";
            } 
            else
            {
                return $"{c + d}";
            }
        }
    }
}
