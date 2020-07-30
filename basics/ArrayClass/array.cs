using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 34, 72, 13, 44, 25, 30, 10 }; 
            int[] temp = list;
            int[] temp1;
            Console.Write("Original Array: "); 
            foreach (int i in list) 
            {
                Console.Write(i + " "); 
            } 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            // reverse the array 
            Array.Reverse(temp);
            Console.Write("Reversed Array: "); 
            foreach (int i in temp) 
            { 
                Console.Write(i + " "); 
            } 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //sort the array 
            Array.Sort(list); 
            Console.Write("Sorted Array: "); 
            foreach (int i in list) 
            { 
                Console.Write(i + " "); 
            } 
            Console.WriteLine(); 
            Console.ReadKey();
        }
    }
}
