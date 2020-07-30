using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NullableValue
{
    class Program
    {
        static void Main(string[] args)
        {
          int? num1 = null; 
            int? num2 = 45; 
            double? num3 = 3.14157; 
            bool? boolval = null; 
            // display the values 
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}", num1, num2, num3); 
            Console.WriteLine("A Nullable boolean value: {0}", boolval); 
            Console.ReadLine(); 
        }
        }
    }

