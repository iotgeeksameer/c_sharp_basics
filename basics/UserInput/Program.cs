using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            const double taxrate = 0.6;
            double itemprice, total;
            Console.WriteLine("enter the item price");
            itemprice = Convert.ToDouble(Console.ReadLine());
            total = itemprice + taxrate;
            Console.WriteLine("total price of the item is {0}, with the tax rate{1}", total, taxrate);
            Console.ReadLine();
        }
    }
}
