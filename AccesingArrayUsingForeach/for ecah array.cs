using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccesingArrayUsingForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10]; /* n is an array of 10 integers */ 
            /* initialize elements of array n */
            for (int i = 0; i < 10; i++) 
            { 
                n[i] = i + 100; 
            } 
            /* output each array element's value */
            int p = 0;
            foreach (int j in n) 
            {  
                Console.WriteLine("Element[{0}] = {1}", p, j);
                p++; 
            } 
            Console.ReadKey();
        }
    }
}
