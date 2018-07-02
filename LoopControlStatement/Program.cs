using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LoopControlStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10; /* do loop execution */ 
            do { if (a == 15) 
            {
                /* skip the iteration */ 
                a = a + 1; 
                break; 
            } 
                Console.WriteLine("value of a: {0}", a); 
                a++; 
            } while (a < 20); 
            Console.ReadLine();
        }
    }
}
