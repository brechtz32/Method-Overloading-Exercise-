﻿namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.2m, 3.4m));
            Console.WriteLine(Add(5, 6, true));
            Console.WriteLine(Add(5, 6, false));
            Console.WriteLine(Add(0, 1, true));
        }

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
