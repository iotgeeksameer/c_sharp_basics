using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ForeachLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[5]; // declaring array

            //Storing value in array element
            arr[0] = "Sameer";
            arr[1] = "Sourabh";
            arr[2] = "Atul";
            arr[3] = "Tarun";
            arr[4] = "Raushan";

            //retrieving value using foreach loop
            foreach (string name in arr)
            {
                Console.WriteLine("Hello " + name);
            }
            Console.ReadLine();
        }
    }
}
