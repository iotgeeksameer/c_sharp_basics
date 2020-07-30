using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    class Test1
    {
        //Private fields of class
        int A, B;
        //default Constructor
        public Test1()
        {
            A = 10;
            B = 20;
        }
        //Paremetrized Constructor
        public Test1(int X, int Y)
        {
            A = X;
            B = Y;
        }
        //Method to print
        public void Print()
        {
            Console.WriteLine("A  =  {0}\tB  =  {1}", A, B);
        }
    }
    class MainClass
    {
        static void Main()
        {
            Test1 T1 = new Test1();  //Default Constructor is called
            Test1 T2 = new Test1(80, 40); //Parameterized Constructor is called
            T1.Print();
            T2.Print();
            Console.ReadLine();
        }
    } 
}
