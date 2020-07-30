using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataTypesDynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic d = 10;
            dynsmic e = 3.4;
            dynamic res;
            res = d + e;
            Console.WriteLine("the result is {0}", res);
        }
    }
}
