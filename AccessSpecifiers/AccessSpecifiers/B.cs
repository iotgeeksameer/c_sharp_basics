using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessSpecifier1;


namespace AccessSpecifier2
{
    class B : A
    {
        public void showB()
        {
            showAInternal();
            Console.WriteLine("Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            b1.showB();
            b1.sho();
            Console.ReadLine();
        }
    }

}
