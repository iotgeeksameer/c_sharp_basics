using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            long l = i;// IMPLICIT CASTING
            double d= 3.256;
            int p;
            p = (int)d;//explicit casting
            string s = "23";
            int t = Convert.ToInt32(s);//type conversion procedure
            int add, no=123;
            add = no + t;
            Console.WriteLine("l={0},p={1},", l, p);
            Console.WriteLine("addition={0}", add);
            Console.ReadLine();


        }
    }
}
