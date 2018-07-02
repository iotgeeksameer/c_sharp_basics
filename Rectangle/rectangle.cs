using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rectangle
{
    class Rect
    {
        double length;
        double width;
        public void getdata()
        {
            length = 4.5; 
            width = 3.5;
        }
        public double GetArea() 
        { 
            return length * width; 
        }
        public void Display() 
        { 
            Console.WriteLine("Length{0}, width{1}  ", length,width); 
           // Console.WriteLine("Width: {0}", width); 
            Console.WriteLine("Area:{0} ", GetArea()); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rect r = new Rect();
            r.getdata();
            r.Display();
            Console.ReadLine();


        }
    }
}
