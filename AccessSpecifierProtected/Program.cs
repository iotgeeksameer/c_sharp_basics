using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AccessSpecifierProtected
{
    class access
    {
        // String Variable declared as protected
      protected string name;// internal
        public void print()
        {
            Console.WriteLine("\nMy name is " + name);
        }
    }
    class Program : access
    {
        static void Main(string[] args)
        {
           // access ac = new access();
            Program ac= new Program();
            Console.Write("Enter your name:\t");
            // raise error because of its protection level
            ac.name = Console.ReadLine();
            ac.print();
            Console.ReadLine();
        }
    }
}
