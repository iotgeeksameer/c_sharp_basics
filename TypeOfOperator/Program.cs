using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TypeOfOperator
{
    class Program
    {
      static Type _type = typeof(char); // Store Type as field
        static void Main(string[] args)
        {
	Console.WriteLine(_type); 
	Console.WriteLine(typeof(int)); 
	Console.WriteLine(typeof(byte)); 
	Console.WriteLine(typeof(Array)); 
    Console.WriteLine(typeof(int[]));
    Console.WriteLine(typeof(char));
    Console.ReadLine();
        }
    }
}
